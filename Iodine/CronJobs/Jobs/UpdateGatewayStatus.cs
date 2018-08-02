using System;
using System.Threading;
using System.Threading.Tasks;
using Iodine.Abstract.Devices;
using Iodine.Abstract.Message;
using Iodine.CronJobs.Scheduler;
using Iodine.Infrastructure.Amqp.Abstracts;
using Iodine.Infrastructure.Data;
using Iodine.Infrastructure.Setup;

namespace Iodine.CronJobs.Jobs
{
    public class UpdateGatewayStatus: IScheduledTask
    {
        public string Schedule { get; } = "*/1 * * * *";

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            var gatewayId = string.Format("gw-{0:000000}", Utils.Rand(1, 100));
            var gateway = await _db.Set<Gateway>().FindAsync(gatewayId);

            if (gateway == null)
                return;

            var status = Utils.Rand(SeedData.GatewayStatuses);
            var now = DateTimeOffset.UtcNow;
            gateway.LastHeartbeat = now;
            gateway.LastUpdated = now;
            gateway.Status = status;
            _db.Update(gateway);
            await _db.SaveChangesAsync(cancellationToken);
            _dispatcher.Publish(new GatewayStatusUpdatedNotification()
            {
                EventId = Guid.NewGuid().ToString(),
                Type = "gatewayStatusUpdated",
                Data = new PingResponeData()
                {
                    DeviceSerial = gatewayId,
                    LastUpdate = now,
                    DeviceType = "gateway",
                    Status = status
                }
            });
        }

        private readonly IMessageDispatcher _dispatcher;
        private readonly IodineDbContext _db;

        public UpdateGatewayStatus(IMessageDispatcher dispatcher, IodineDbContext db)
        {
            _dispatcher = dispatcher;
            _db = db;
        }
    }
}
