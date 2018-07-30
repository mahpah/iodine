using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Iodine.Abstract.Application;
using Iodine.Abstract.Message;
using Iodine.CronJobs;
using Iodine.Infrastructure.Amqp.Abstracts;
using Iodine.Infrastructure.Data;
using Iodine.RequestHandlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Iodine
{
    internal class IodineServer : IHostedService
    {
        private readonly IodineDbContext _db;
        private readonly ILogger<IodineServer> _logger;
        private readonly IOptions<AppConfig> _appConfig;
        private readonly IRequestHandlerManager _requestHandlerManager;

        public IodineServer(IodineDbContext db,
            ILogger<IodineServer> logger,
            IOptions<AppConfig> appConfig,
            IRequestHandlerManager requestHandlerManager)
        {
            _db = db;
            _logger = logger;
            _appConfig = appConfig;
            _requestHandlerManager = requestHandlerManager;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting service....");
            await _db.Database.MigrateAsync(cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stop service....");
            return Task.CompletedTask;
        }
    }
}
