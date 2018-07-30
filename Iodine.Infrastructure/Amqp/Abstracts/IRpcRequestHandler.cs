using System.Threading.Tasks;
using Iodine.Abstract.Message;

namespace Iodine.Infrastructure.Amqp.Abstracts
{
    public interface IRpcRequestHandler<in T, TOut> where T : RequestBase where TOut : ResponseBase
    {
        Task<TOut> Handle(T request);
    }
}
