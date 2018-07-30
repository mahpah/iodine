using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Iodine.Abstract.Message;
using Iodine.Infrastructure.Amqp.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Polly;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;

namespace Iodine.Infrastructure.Amqp
{
    public class RabbitRpcDispatcher : IRpcDispatcher
    {
        private readonly IAmqpConnection _persistentConnection;
        private IModel _consumeChannel;
        private readonly ILogger<RabbitRpcDispatcher> _logger;
        private readonly IRequestHandlerManager _handlerManager;
        private readonly int _retryCount;
        private readonly IServiceProvider _serviceProvider;
        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public RabbitRpcDispatcher(
            IAmqpConnection persistentConnection,
            ILogger<RabbitRpcDispatcher> logger,
            IServiceProvider serviceProvider,
            IRequestHandlerManager handlerManager,
            int retryCount = 5)
        {
            _persistentConnection = persistentConnection;
            _serviceProvider = serviceProvider;
            _logger = logger;
            _handlerManager = handlerManager;
            _retryCount = retryCount;
            _consumeChannel = CreateConsumeChannel();
        }

        private IModel CreateConsumeChannel()
        {
            if (!_persistentConnection.IsConnected)
            {
                _persistentConnection.TryConnect();
            }

            var channel = _persistentConnection.CreateModel();
            channel.QueueDeclare(queue: "rpc_queue",
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
                    PublishResponse(response, replyProps, props.ReplyTo);
                }
                catch (Exception e)
                {
                    _logger.LogWarning(e, "Cannot handle event");
                    PublishResponse(new ErrorResponse(1, e.Message), replyProps, props.ReplyTo);
                }
                finally
                {
                    channel.BasicAck(deliveryTag: ea.DeliveryTag,
                        multiple: false);
                }
            };

            channel.CallbackException += (sender, ea) =>
            {
                _consumeChannel.Dispose();
                _consumeChannel = CreateConsumeChannel();
            };

            return channel;
        }

        private void PublishResponse(ResponseBase response, IBasicProperties replyProps, string routingKey)
        {
            var responseBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(response, JsonSettings));
            if (!_persistentConnection.IsConnected)
            {
                _persistentConnection.TryConnect();
            }

            var policy = Policy.Handle<BrokerUnreachableException>()
                .Or<SocketException>()
                .WaitAndRetry(_retryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) =>
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
            _consumeChannel?.Dispose();
        }
    }
}
