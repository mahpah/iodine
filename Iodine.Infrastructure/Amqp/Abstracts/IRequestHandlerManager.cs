using System;
using Iodine.Abstract.Message;

namespace Iodine.Infrastructure.Amqp.Abstracts
{
    public interface IRequestHandlerManager
    {
        void ScanRequest();

        void AddSubscription<T, TH, TOut>()
            where T : RequestBase
            where TH : IRpcRequestHandler<T, TOut>
            where TOut : ResponseBase;

        bool HasHandler(string requestType);

        RpcSubscriptionInfo GetSubscription(string requestType);
    }

    public class RpcSubscriptionInfo
    {
        public Type HandlerType{ get; }
        public Type ResponseType { get; }
        public Type RequestType { get; }

        public RpcSubscriptionInfo(Type handlerType, Type responseType, Type requestType)
        {
            HandlerType = handlerType;
            ResponseType = responseType;
            RequestType = requestType;
        }
    }
}
