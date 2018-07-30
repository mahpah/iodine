using Iodine.Infrastructure.Amqp.Abstracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;

namespace Iodine.Infrastructure.Amqp.DependencyInjection
{
    public static class DependencyInjectionExtension
    {
        private const string ConfigSectionName = "RabitRpc";

        internal class ConnectionConfig
        {
            public string HostName { get; set; } = "localhost";
            public int Port { get; set; } = 5672;
            public string UserName { get; set; } = "guest";
            public string Password { get; set; } = "guest";
            public int Retry { get; set; } = 5;
            public string RpcQueueName { get; set; } = "rpc_queue";
            public string EventBusQueueName { get; set; } = "event_bus";
        }

        public static void AddRabbitRpc(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionConfig = new ConnectionConfig();
            configuration.GetSection(ConfigSectionName).Bind(connectionConfig);
            services.AddSingleton<IAmqpConnection>(sp =>
            {
                var logger = sp.GetRequiredService<ILogger<RabbitMqConnection>>();
                var connectionFactory = new ConnectionFactory
                {
                    HostName = connectionConfig.HostName,
                    Port = connectionConfig.Port,
                    UserName = connectionConfig.UserName,
                    Password = connectionConfig.Password,
                };

                return new RabbitMqConnection(connectionFactory, logger, connectionConfig.Retry);
            });

            services.AddSingleton<IRequestHandlerManager, InMemoryRequestHandlerManager>();
            services.AddSingleton<IMessageDispatcher, RabbitMessageDispatcher>(serviceProvider =>
            {
                var connection = serviceProvider.GetRequiredService<IAmqpConnection>();
                var logger = serviceProvider.GetRequiredService<ILogger<RabbitMessageDispatcher>>();
                var retryCount = connectionConfig.Retry;
                var subManager = serviceProvider.GetRequiredService<IRequestHandlerManager>();
                return new RabbitMessageDispatcher(
                    persistentConnection: connection,
                    logger: logger,
                    serviceProvider: serviceProvider,
                    handlerManager: subManager,
                    rpcQueueName: connectionConfig.RpcQueueName,
                    retryCount: retryCount);
            });
        }
    }
}
