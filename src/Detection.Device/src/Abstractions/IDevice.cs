// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

namespace Wangkanai.Detection
{
    /// <summary>
    /// IDevice is the interface result of the <see cref="DeviceResolver"/>.
    /// </summary>
    public interface IDevice
    {
        DeviceType Type { get; set; }
        bool Crawler { get; set; }
    }
}
