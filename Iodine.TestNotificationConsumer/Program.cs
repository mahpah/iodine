using System;
using System.Linq;
using System.Text;
using Iodine.Abstract.Message;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Iodine.TestNotificationConsumer
{
    class Program
    {
        private const string QueueName = "event_queue";

        static void Main(string[] args)
        {
            if (!int.TryParse(args[2], out var port))
                port = 5672;

            DoSubscribe(
                hostName: args[1],
                port: port,
                userName: args[3],
                password:args[4]);
        }

        private static void DoSubscribe(string hostName, int port, string userName, string password)
        {
            Console.WriteLine("Connect to {0}, {1}, {2}, {3}", hostName, port, userName, password);
            var factory = new ConnectionFactory()
            {
                HostName = hostName,
                Port = port,
                UserName = userName,
                Password = password
            };
            using(var connection = factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: QueueName,
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                channel.ExchangeDeclare(exchange: "event_bus", type: "direct");

                var eventTypes = typeof(NotificationBase).Assembly.GetTypes()
                    .Where(x => typeof(NotificationBase).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                    .Select(x => x.Name)
                    .ToList();

                foreach (var type in eventTypes)
                {
                    channel.QueueBind(queue: QueueName, exchange: "event_bus", routingKey: type);
                }

                Console.WriteLine(" [*] Waiting for messages. To exit press CTRL+C");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    var routingKey = ea.RoutingKey;
                    Console.WriteLine(" [x] Received '{0}':'{1}'",
                        routingKey,
                        message);
                };

                channel.BasicConsume(queue: QueueName,
                    autoAck: true,
                    consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
