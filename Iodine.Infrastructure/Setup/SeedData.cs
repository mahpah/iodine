﻿using System;
using System.Collections.Generic;
using System.Linq;
using Iodine.Abstract.Devices;

namespace Iodine.Infrastructure.Setup
{
    public class SeedData
    {
        public static readonly string[] GatewayStatuses = { "connected", "warn", "error", "disconnected" };

        public static readonly string[] DeviceTypes =
            {"alarmbell", "directionlight", "primaryalarmbell", "smokedetector", "station", "sprinkler"};

        public static Gateway[] Gateways = Enumerable.Range(1, 100).Select(index => new Gateway()
        {
            SerialNumber = string.Format("gw-{0:000000}", index),
            Status = Utils.Rand(GatewayStatuses),
            LastHeartbeat = DateTimeOffset.Now,
        }).ToArray();

        public static ConnectedDevice[] ConnectedDevices = Enumerable.Range(1, 1000).SelectMany(index =>
        {
            return  DeviceTypes.Select(type =>
            {
                var id = Utils.Rand(1, 103);
                var gId = id < 100 ? string.Format("gw-{0:000000}", id) : null;

                return new ConnectedDevice()
                {
                    Status = "connected",
                    Type = type,
                    SerialNumber = string.Format("{0}-{1:000000}", type.Substring(0, 2), index),
                    LastHeartbeat = DateTimeOffset.Now,
                    GatewayId = gId,
                };
            });
        }).ToArray();
    }
}
