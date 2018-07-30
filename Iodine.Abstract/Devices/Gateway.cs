﻿namespace Iodine.Abstract.Devices
{
    public class Gateway : DeviceBase
    {
        public string Status { get; set; }
    }

    public class ConnectedDevice : DeviceBase
    {
        public string GatewayId { get; set; }

        public virtual Gateway Gateway { get; set; }

        public virtual string Status { get; set; } = "working";
    }
}
