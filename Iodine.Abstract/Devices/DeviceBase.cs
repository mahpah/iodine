using System;
using System.ComponentModel.DataAnnotations;

namespace Iodine.Abstract.Devices
{
    public abstract class DeviceBase
    {
        [Key]
        public string SerialNumber { get; set; }

        public string Type { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset LastUpdated { get; set; }

        public DateTimeOffset LastHeartbeat { get; set; }
    }
}
