// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Wangkanai.Detection.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Contains extension method to <see cref="IServiceCollection"/> for configuring client services.
    /// </summary>
    public static class CoreBuilderExtensions
    {
        /// <summary>
        /// Adds the default client service to the services container.
        /// </summary>
        /// <param name="services">The services available in the application.</param>
        /// <returns>An <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IDetectionCoreBuilder AddCoreServices(this IServiceCollection services)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            // Hosting doesn't add IHttpContextAccessor by default
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Client Services
            services.TryAddTransient<IUserAgentService, UserAgentService>();

            services.AddOptions();
            services.TryAddSingleton<DetectionMarkerService, DetectionMarkerService>();

            return new DetectionCoreBuilder(services);
        }
    }
}