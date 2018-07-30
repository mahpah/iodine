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
            DoSubscribe();
        }

        private static void DoSubscribe()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
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
