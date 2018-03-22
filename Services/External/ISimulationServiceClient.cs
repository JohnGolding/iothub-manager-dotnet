﻿// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Azure.IoTSolutions.IotHubManager.Services.External
{
    public interface ISimulationServiceClient
    {
        Task<HashSet<string>> GetDevicePropertyNamesAsync();
    }
}
