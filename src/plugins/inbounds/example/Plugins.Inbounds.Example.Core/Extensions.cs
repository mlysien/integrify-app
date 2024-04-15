using Integrify.Shared.Infrastructure.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Plugins.Inbounds.Example.Core.Contracts;
using Plugins.Inbounds.Example.Service;

namespace Plugins.Inbounds.Example.Core;

public static class Extensions
{
    public static void AddCoreLayer(this IServiceCollection services)
    {
        services.AddServicesLayer();
    }

    public static void UseCoreLayer(this IApplicationBuilder app)
    {
        app.UseContracts().Register<OrderSynchronizationContract>();
    }
}

