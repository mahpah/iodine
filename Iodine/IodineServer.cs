using System.Threading;
using System.Threading.Tasks;
using Iodine.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Iodine
{
    internal class IodineServer : IHostedService
    {
        private readonly IodineDbContext _db;
        private readonly ILogger<IodineServer> _logger;

        public IodineServer(IodineDbContext db,
            ILogger<IodineServer> logger)
        {
            _db = db;
            _logger = logger;
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
