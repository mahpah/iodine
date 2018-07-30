using System.Threading.Tasks;
using Iodine.Abstract.Message;
using Iodine.Infrastructure.Amqp.Abstracts;

namespace Iodine.RequestHandlers
{
    public class PingRequestHandler : IRpcRequestHandler<PingRequest, PingResponse>
    {
        public Task<PingResponse> Handle(PingRequest request)
        {
            return Task.FromResult(new PingResponse()
            {
                Data = new PingResponeData()
                {
                    DeviceSerial = request.DeviceSerial,
                }
            });
        }
    }
}
