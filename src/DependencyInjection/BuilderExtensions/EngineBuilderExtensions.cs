// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection.Extensions;

using Wangkanai.Detection;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class EngineBuilderExtensions
    {
        public static IDetectionCoreBuilder AddEngineService(this IDetectionCoreBuilder builder)
        {
            builder.Services.TryAddTransient<IEngineResolver, EngineResolver>();

            return builder;
        }
    }
}