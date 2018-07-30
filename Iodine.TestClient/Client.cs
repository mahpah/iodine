using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using Iodine.Abstract.Message;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Iodine.TestClient
{

    public class RpcClient
    {
        private readonly IConnection connection;
        private readonly IModel channel;
        private readonly string replyQueueName;
        private readonly EventingBasicConsumer consumer;
        private readonly BlockingCollection<string> respQueue = new BlockingCollection<string>();
        private readonly IBasicProperties props;

        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
        };

        public RpcClient()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
            };

            connection = factory.CreateConnection();
            channel = connection.CreateModel();
            replyQueueName = channel.QueueDeclare().QueueName;
            consumer = new EventingBasicConsumer(channel);

            props = channel.CreateBasicProperties();
            var correlationId = Guid.NewGuid().ToString();
            props.CorrelationId = correlationId;
            props.ReplyTo = replyQueueName;

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var response = Encoding.UTF8.GetString(body);
                if (ea.BasicProperties.CorrelationId == correlationId)
                {
                    respQueue.Add(response);
                }
            };
        }

        public T Call<T>(RequestBase request) where T : ResponseBase
        {
            var str = JsonConvert.SerializeObject(request, JsonSettings);
            var messageBytes = Encoding.UTF8.GetBytes(str);
            channel.BasicPublish(
                exchange: "",
                routingKey: "rpc_queue",
                basicProperties: props,
                body: messageBytes);

            channel.BasicConsume(
                consumer: consumer,
                queue: replyQueueName,
                autoAck: true);

            var responseString = respQueue.Take();
            return JsonConvert.DeserializeObject<T>(responseString, JsonSettings);
        }

        public void Close()
        {
            connection.Close();
        }

        private class Response : ResponseBase
        {

        }
    }

    public class Client
    {
        public static void Main(string[] args)
        {
            var rpcClient = new RpcClient();

            foreach (var arg in args.Skip(1))
            {
                Console.WriteLine(" [x] Ping {0}", arg);

                var response = rpcClient.Call<PingResponse>(new PingRequest
                {
                    DeviceSerial = arg
                });
                Console.WriteLine(" [{0}] Got '{1}'", response.Success ? "S" : "E", response.Success ? response.Data.Status : "---");
            }

            rpcClient.Close();
        }
    }
}
