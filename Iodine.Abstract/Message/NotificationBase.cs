using System;
using System.Globalization;

namespace Iodine.Abstract.Message
{
    public abstract class NotificationBase
    {
        public string Type { get; set; }

        public string EventId { get; set; }

        public string Timestamp { get; set; } = DateTimeOffset.UtcNow.ToUnixTimestamp();
    }

    public static class TimeHelper
    {
        public static string ToUnixTimestamp(this DateTimeOffset dateTimeOffset)
        {
            var a = dateTimeOffset.Subtract(new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.FromMilliseconds(0)));
            return ((int) a.TotalSeconds).ToString(CultureInfo.InvariantCulture);
        }
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

    public class FireAlarmNotification : NotificationBase<FireAlarmNotificationData> {}

    public class FireAlarmCanceledNotificationData
    {
        public string InitializingDevice { get; set; }
        public string Gateway { get; set; }
        public string DeviceType { get; set; }
    }

    public class FireAlarmCanceledNotification : NotificationBase<FireAlarmCanceledNotificationData> {}

    public class DeviceStatusUpdatedNotification : NotificationBase<PingResponeData> {}
    public class GatewayStatusUpdatedNotification : NotificationBase<PingResponeData> {}
}
