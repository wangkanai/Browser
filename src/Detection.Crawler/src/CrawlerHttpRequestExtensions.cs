// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Microsoft.AspNetCore.Http
{
    public static class CrawlerHttpRequestExtensions
    {
        public static ICrawler Crawler(this HttpRequest request)
        {
            var service = new UserAgentService(request.HttpContext);
            var resolver = new CrawlerResolver(service);
            return resolver.Crawler;
        }
    }
}
