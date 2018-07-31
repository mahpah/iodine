using System;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Iodine.Abstract.Exceptions;
using Iodine.Abstract.Message;
using Iodine.Infrastructure.Amqp.Abstracts;
using Iodine.Infrastructure.Setup;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Polly;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using SQLitePCL;

namespace Iodine.Infrastructure.Amqp
{
    public class RabbitMessageDispatcher : IMessageDispatcher
    {
        private readonly IAmqpConnection _persistentConnection;
        private IModel _rpcChannel;
        private IModel _eventChannel;
        private readonly ILogger<RabbitMessageDispatcher> _logger;
        private readonly IRequestHandlerManager _handlerManager;
        private readonly int _retryCount;
        private readonly IServiceProvider _serviceProvider;
        private readonly string _rpcQueueName;
        private readonly string _eventQueueName;
        private const string _brokerName = "iodine_platform";

        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
        };

        public RabbitMessageDispatcher(
            IAmqpConnection persistentConnection,
            ILogger<RabbitMessageDispatcher> logger,
            IServiceProvider serviceProvider,
            IRequestHandlerManager handlerManager,
            string rpcQueueName = "rpc_queue",
            string eventQueueName = "event_queue",
            int retryCount = 5)
        {
            _persistentConnection = persistentConnection;
            _serviceProvider = serviceProvider;
            _logger = logger;
            _handlerManager = handlerManager;
            _eventQueueName = eventQueueName;
            _rpcQueueName = rpcQueueName;
            _retryCount = retryCount;

            _rpcChannel = CreateRpcChannel();
            _eventChannel = CreateEventChannel();
        }

        private IModel CreateRpcChannel()
        {
            if (!_persistentConnection.IsConnected)
            {
                _persistentConnection.TryConnect();
            }

            var channel = _persistentConnection.CreateModel();
            channel.QueueDeclare(queue: _rpcQueueName,
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            channel.BasicConsume(queue: "rpc_queue", autoAck: false, consumer: consumer);

            consumer.Received += async (model, ea) =>
            {
                var body = ea.Body;
                var props = ea.BasicProperties;
                var replyProps = channel.CreateBasicProperties();
                replyProps.CorrelationId = props.CorrelationId;

                try
                {
                    var message = Encoding.UTF8.GetString(body);
                    var response = await ProcessEvent(message);
                    PublishRpcResponse(response, replyProps, props.ReplyTo);
                }
                catch (PlatformError e)
                {
                    PublishRpcResponse(new ErrorResponse(e.Code, e.Message), replyProps, props.ReplyTo);
                }
                catch (Exception e)
                {
                    _logger.LogWarning(e, "Cannot handle event");
                    PublishRpcResponse(new ErrorResponse(500, e.Message), replyProps, props.ReplyTo);
                }
                finally
                {
                    channel.BasicAck(deliveryTag: ea.DeliveryTag,
                        multiple: false);
                }
            };

            channel.CallbackException += (sender, ea) =>
            {
                _rpcChannel.Dispose();
                _rpcChannel = CreateRpcChannel();
            };

            return channel;
        }

        private IModel CreateEventChannel()
        {
            if (!_persistentConnection.IsConnected)
            {
                _persistentConnection.TryConnect();
            }

            var channel = _persistentConnection.CreateModel();

            channel.ExchangeDeclare(exchange: _brokerName,
                type: "direct");

            channel.QueueDeclare(queue: _eventQueueName,
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            // may consume event here, if needed
            // var consumer = new EventingBasicConsumer(channel);
            // channel.BasicConsume(queue: "rpc_queue", autoAck: false, consumer: consumer);
            // consumer.Received += async (model, ea) =>
            // {
            // };

            channel.CallbackException += (sender, ea) =>
            {
                _eventChannel.Dispose();
                _eventChannel = CreateRpcChannel();
            };

            return channel;
        }

        private void PublishRpcResponse(ResponseBase response, IBasicProperties replyProps, string routingKey)
        {
            var responseBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(response, JsonSettings));
            if (!_persistentConnection.IsConnected)
            {
                _persistentConnection.TryConnect();
            }

            var policy = Policy.Handle<BrokerUnreachableException>()
                .Or<SocketException>()
                .WaitAndRetry(_retryCount, (retryAttempt) => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) =>
                {
                    _logger.LogWarning(ex, "Error send response to a broken connection");
                });

            using (var channel = _persistentConnection.CreateModel())
            {
                policy.Execute(() =>
                {
                    channel.BasicPublish(exchange: "",
                        routingKey: routingKey,
                        basicProperties: replyProps,
                        body: responseBytes);
                });
            }
        }

        public void Publish(NotificationBase @event)
        {
            if (!_persistentConnection.IsConnected)
            {
                _persistentConnection.TryConnect();
            }

            var policy = Policy.Handle<BrokerUnreachableException>()
                .Or<SocketException>()
                .WaitAndRetry(_retryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) =>
                {
                    _logger.LogWarning(ex.ToString());
                });

            using (var channel = _persistentConnection.CreateModel())
            {
                var eventName = GetEventKey(@event);

                channel.ExchangeDeclare(exchange: _brokerName, type: "direct");
                channel.QueueBind(queue: _eventQueueName, exchange: _brokerName, routingKey: eventName);
                var message = JsonConvert.SerializeObject(@event);
                _logger.LogDebug(message);
                var body = Encoding.UTF8.GetBytes(message);

                policy.Execute(() =>
                {
                    var properties = channel.CreateBasicProperties();
                    properties.DeliveryMode = 2; // persistent
                    channel.BasicPublish(exchange: _brokerName,
                        routingKey: eventName,
                        mandatory: true,
                        basicProperties: properties,
                        body: body);
                });
            }
        }

        private static readonly Regex SuffixRegex = new Regex(@"Notification$");
        private static string GetEventKey<T>(T @event) where T:NotificationBase
        {
            return SuffixRegex.Replace(@event.GetType().Name.ToCamelCasing(), string.Empty);
        }

        private async Task<ResponseBase> ProcessEvent(string message)
        {
            var requestTypeName = RequestBase.GetType(message);

            if (!_handlerManager.HasHandler(requestTypeName)) return default(ResponseBase);

            using (var scope = _serviceProvider.CreateScope())
            {
                var subscription = _handlerManager.GetSubscription(requestTypeName);
                var requestType = subscription.RequestType;
                var request = JsonConvert.DeserializeObject(message, requestType);
                var handlerType = scope.ServiceProvider.GetService(subscription.HandlerType);
                var responseType = subscription.ResponseType;
                var concreteType = typeof(IRpcRequestHandler<,>).MakeGenericType(requestType, responseType);
                var task = (Task) concreteType.GetMethod("Handle").Invoke(handlerType, new[] { request });
                var res = task.GetType().GetProperty("Result").GetValue(task);
                return (ResponseBase)res;
            }
        }

        public void Dispose()
        {
            _rpcChannel?.Dispose();
        }
    }
}
