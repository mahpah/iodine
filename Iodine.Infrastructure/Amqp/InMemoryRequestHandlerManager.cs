using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Iodine.Abstract.Message;
using Iodine.Infrastructure.Amqp.Abstracts;

namespace Iodine.Infrastructure.Amqp
{
    public class InMemoryRequestHandlerManager : IRequestHandlerManager
    {
        private readonly Dictionary<string, RpcSubscriptionInfo> _handlers;

        public event EventHandler<string> OnEventRemoved;

        public InMemoryRequestHandlerManager()
        {
            _handlers = new Dictionary<string, RpcSubscriptionInfo>();
        }

        public void AddSubscription<T, TH, TOut>()
            where T : RequestBase
            where TH : IRpcRequestHandler<T, TOut>
            where TOut: ResponseBase
        {
            var eventName = GetEventKey<T>();
            if (HasHandler(eventName))
            {
                throw new ArgumentException("Only one request handler can be registered");
            }

            _handlers[eventName] = new RpcSubscriptionInfo(handlerType: typeof(TH),
                responseType: typeof(TOut),
                requestType: typeof(T));
        }

        public void ScanRequest()
        {
            throw new NotImplementedException();
        }

        public bool HasHandler(string requestType)
        {
            return !string.IsNullOrEmpty(requestType) && _handlers.ContainsKey(requestType.ToLowerInvariant());
        }

        public RpcSubscriptionInfo GetSubscription(string requestType)
        {
            return _handlers[requestType];
        }

        private static readonly Regex RequestTypeRegex = new Regex(@"request$");

        private static string GetEventKey<T>()
        {
            var typeName = typeof(T).Name.ToLowerInvariant();
            return RequestTypeRegex.Replace(typeName, string.Empty);
        }
    }
}
