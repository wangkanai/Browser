﻿// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace Wangkanai.Detection
{
    public interface IDetectionService
    {
        HttpContext Context { get; }
        IUserAgent UserAgent { get; }
    }
}
