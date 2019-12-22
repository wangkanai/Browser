// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

using Wangkanai.Responsive;
using Wangkanai.Responsive.Builders;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// ASP.NET Core middleware for routing to specific area base client request device
    /// Extension method for setting up Universal in an <see cref="IServiceCollection" />
    /// </summary>
    public static class ResponsiveCollectionExtensions
    {
        /// <summary>
        /// Adds services required for application Responsive.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IResponsiveBuilder AddResponsive(this IServiceCollection services)
        {
            if (services == null) throw new AddResponsiveArgumentNullException(nameof(services));

            services.AddResponsiveCore()
                .AddViewSuffix()
                .AddViewSubfolder();

            return new ResponsiveBuilder(services);
        }
    }
}
