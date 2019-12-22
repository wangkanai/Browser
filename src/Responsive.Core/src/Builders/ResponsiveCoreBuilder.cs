// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.Responsive.Builders
{
    public class ResponsiveCoreBuilder : IResponsiveCoreBuilder
    {
        public IServiceCollection Services { get; }

        public ResponsiveCoreBuilder(
            IServiceCollection services)
        {
            Services = services
                ?? throw new ResponsiveCoreBuilderArgumentNullException(nameof(services));
        }
    }
}
