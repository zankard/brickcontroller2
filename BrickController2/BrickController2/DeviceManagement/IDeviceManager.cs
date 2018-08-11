﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace BrickController2.DeviceManagement
{
    public interface IDeviceManager
    {
        Task ScanAsync(CancellationToken token);
    }
}
