using System.Threading.Tasks;
using Iodine.Abstract.Devices;
using Iodine.Abstract.Exceptions;
using Iodine.Abstract.Message;
using Iodine.Infrastructure.Amqp.Abstracts;
using Iodine.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Iodine.RequestHandlers
{
    public class PingRequestHandler : IRpcRequestHandler<PingRequest, PingResponse>
    {
        private readonly IodineDbContext _db;

        public PingRequestHandler(IodineDbContext db)
        {
            _db = db;
        }

        public async Task<PingResponse> Handle(PingRequest request)
        {
            var deviceBase = await _db.Set<DeviceBase>().FirstOrDefaultAsync(t => t.SerialNumber == request.DeviceSerial);

            if (deviceBase == null)
            {
                throw new PlatformError(404, "device not found");
            }

            if (deviceBase.Type == "gateway")
            {
                var gateway = await _db.Set<Gateway>().FirstOrDefaultAsync(t => t.SerialNumber == request.DeviceSerial);
                return new PingResponse()
                {
                    Success = true,
                    Data = new PingResponeData()
                    {
                        DeviceSerial = gateway.SerialNumber,
                        Status = gateway.Status,
                        LastUpdate = gateway.LastUpdated,
                    }
                };
            }

            var device = await _db.Set<ConnectedDevice>().FirstOrDefaultAsync(t => t.SerialNumber == request.DeviceSerial);
            return new PingResponse()
            {
                Success = true,
                Data = new PingResponeData()
                {
                    DeviceSerial = request.DeviceSerial,
                    Status = device.Status,
                    LastUpdate = device.LastUpdated,
                    ConnectedGateway = device.GatewayId,
                }
            };
        }
    }
}
