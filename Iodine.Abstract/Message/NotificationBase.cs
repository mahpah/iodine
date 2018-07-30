namespace Iodine.Abstract.Message
{
    public abstract class NotificationBase
    {
        public string Type { get; set; }

        public string EventId { get; set; }

        public int Timestamp { get; set; }
    }

    public abstract class NotificationBase<T> : NotificationBase
    {
        public T Data { get; set; }
    }

    public class FireAlarmNotificationData
    {
        public string InitializingDevice { get; set; }
        public string Gateway { get; set; }
        public string DeviceType { get; set; }
    }

    public class FireAlarmCanceledNotificationData
    {
        public string InitializingDevice { get; set; }
        public string Gateway { get; set; }
        public string DeviceType { get; set; }
    }
}
