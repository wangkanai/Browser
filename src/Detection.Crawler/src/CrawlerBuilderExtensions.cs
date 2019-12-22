// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CrawlerBuilderExtensions
    {
        public static IDetectionCoreBuilder AddCrawler(this IDetectionCoreBuilder builder)
        {
            builder.Services.AddTransient<ICrawlerResolver, CrawlerResolver>();

            return builder;
        }
    }
}
