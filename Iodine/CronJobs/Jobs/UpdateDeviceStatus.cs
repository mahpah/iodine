using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Iodine.Abstract.Devices;
using Iodine.Abstract.Message;
using Iodine.CronJobs.Scheduler;
using Iodine.Infrastructure.Amqp.Abstracts;
using Iodine.Infrastructure.Data;
using Iodine.Infrastructure.Setup;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Iodine.CronJobs.Jobs
{
    public class UpdateDeviceStatus : IScheduledTask
    {
        public string Schedule { get; } = "*/1 * * * *";
        private readonly IMessageDispatcher _dispatcher;
        private readonly string[] _deviceStatuses;
        private readonly IodineDbContext _db;

        public UpdateDeviceStatus(IMessageDispatcher dispatcher, IConfiguration configuration, IodineDbContext db)
        {
            _dispatcher = dispatcher;
            _db = db;
            var list = new List<string>();
            configuration.GetSection("DeviceStatuses").Bind(list);
            _deviceStatuses = list.ToArray();
        }

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            var devices = RandomDevices();
            var serials = devices.Select(t => t.SerialNumber);
            var notis = new List<DeviceStatusUpdatedNotification>();

            var current = await _db.Set<ConnectedDevice>()
                .Where(t => serials.Contains(t.SerialNumber))
                .ToListAsync(cancellationToken: cancellationToken);

            foreach (var device in current)
            {
                device.Status = devices.FirstOrDefault(t => t.SerialNumber == device.SerialNumber)?.Status ?? "error";
                notis.Add(new DeviceStatusUpdatedNotification()
                {
                    Data = new PingResponeData()
                    {
                        DeviceSerial = device.SerialNumber,
                        Status = device.Status,
                    }
                });
            }

            _db.UpdateRange(current);
            await _db.SaveChangesAsync(cancellationToken);

            foreach (var noti in notis)
            {
                _dispatcher.Publish(noti);
            }
        }

        private IList<ConnectedDevice> RandomDevices()
        {
            var number = Utils.Rand(1, 5);
            return Enumerable.Range(1, number).Select(t =>
            {
                var type = Utils.Rand(SeedData.DeviceTypes);
                var id = Utils.Rand(1, 100);
                var status = Utils.Rand(_deviceStatuses);

                var deviceSerial = string.Format("{0}-{1:000000}", type.Substring(0, 2), id);

                return new ConnectedDevice()
                {
                    SerialNumber = deviceSerial,
                    LastHeartbeat = DateTimeOffset.UtcNow,
                    LastUpdated = DateTimeOffset.UtcNow,
                    Status = status
                };
            }).ToList();
        }
    }
}
