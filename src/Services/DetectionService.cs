// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection.Models;

namespace Wangkanai.Detection.Services
{
    public class DetectionService : IDetectionService
    {
        public UserAgent UserAgent { get; }
        public IDeviceService Device { get; }
        public ICrawlerService Crawler { get; }
        public IBrowserService Browser { get; }
        public IEngineService Engine { get; }
        public IPlatformService Platform { get; }

        public DetectionService(
            IUserAgentService userAgentService,
            IDeviceService    device,
            ICrawlerService   crawler,
            IBrowserService   browser,
            IEngineService    engine,
            IPlatformService  platform)
            : this(userAgentService.UserAgent, device, crawler, browser, engine, platform) { }

        public DetectionService(
            UserAgent ua,
            IDeviceService    device,
            ICrawlerService   crawler,
            IBrowserService   browser,
            IEngineService    engine,
            IPlatformService  platform)
        {
            UserAgent = ua;
            Device    = device;
            Crawler   = crawler;
            Browser   = browser;
            Engine    = engine;
            Platform  = platform;
        }
    }
}
