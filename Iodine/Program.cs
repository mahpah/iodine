using System;
using System.Threading.Tasks;
using Iodine.Abstract.Application;
using Iodine.Abstract.Message;
using Iodine.CronJobs.DI;
using Iodine.CronJobs.Jobs;
using Iodine.CronJobs.Scheduler;
using Iodine.Infrastructure.Amqp.Abstracts;
using Iodine.Infrastructure.Amqp.DependencyInjection;
using Iodine.Infrastructure.Data;
using Iodine.RequestHandlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Iodine
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            NpgsqlConnection.GlobalTypeMapper.UseNodaTime();

            var builder = new HostBuilder()
                .ConfigureAppConfiguration(ConfigureAppConfiguration)
                .ConfigureServices(ConfigureServices)
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                });

            var host  = builder.Build();

            var requestHandlerManager = host.Services.GetRequiredService<IRequestHandlerManager>();
            host.Services.GetRequiredService<IAmqpConnection>();
            host.Services.GetRequiredService<IMessageDispatcher>();
            requestHandlerManager.AddSubscription<PingRequest, PingRequestHandler, PingResponse>();

            await host.RunAsync();
        }

        private static void ConfigureAppConfiguration(HostBuilderContext hostingContext, IConfigurationBuilder config)
        {
            config.AddJsonFile("appsettings.json", optional: true);
            config.AddEnvironmentVariables();
        }

        private static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<AppConfig>(hostContext.Configuration.GetSection("AppConfig"));
            services.AddTransient<PingRequestHandler>();
            services.AddRabbitRpc(hostContext.Configuration);

            services.AddDbContext<IodineDbContext>(options =>
            {
                options.UseSqlite(hostContext.Configuration.GetConnectionString("Default"));
            });

            services.AddSingleton<IHostedService, IodineServer>();
            services.AddSingleton<IScheduledTask, UpdateDeviceStatus>();
            services.AddScheduler((sender, args) =>
            {
                Console.Write(args.Exception.Message);
                args.SetObserved();
            });
        }
    }
}
