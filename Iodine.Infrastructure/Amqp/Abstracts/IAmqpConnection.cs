using System;
using RabbitMQ.Client;

namespace Iodine.Infrastructure.Amqp.Abstracts
{
    public interface IAmqpConnection : IDisposable
    {
        bool IsConnected { get; }
        IModel CreateModel();
        bool TryConnect();
    }
}
