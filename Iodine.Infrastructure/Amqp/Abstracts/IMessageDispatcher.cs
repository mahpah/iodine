using System;
using Iodine.Abstract.Message;

namespace Iodine.Infrastructure.Amqp.Abstracts
{
    public interface IMessageDispatcher : IDisposable
    {
        void Publish(NotificationBase notification);
    }
}
