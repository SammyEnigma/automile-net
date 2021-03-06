﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automile.Net
{
    public class UserDeviceCreateModel
    {
        public string DeviceIdentifier { get; set; }
        public string DeviceToken { get; set; }

        public ApiDeviceType DeviceType { get; set; }

        public string Description { get; set; }

        public string DeviceName { get; set; }
    }

    public class UserDeviceCreateModel2
    {
        public string DeviceIdentifier { get; set; }
        public string DeviceToken { get; set; }

        public ApiDeviceType DeviceType { get; set; }

        public ApiUserDeviceCertType UserDeviceCertType { get; set; }

        public string Description { get; set; }

        public string DeviceName { get; set; }
    }
}
