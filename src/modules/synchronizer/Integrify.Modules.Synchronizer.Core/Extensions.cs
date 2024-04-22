using Integrify.Modules.Synchronizer.Core.Contracts;
using Integrify.Shared.Infrastructure.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Synchronizer.Core;

public static class Extensions
{
    public static void AddCoreLayer(this IServiceCollection services)
    {
    }

    public static void UseCoreLayer(this IApplicationBuilder app)
    {
        app.UseContracts().Register<CustomersSynchronizationContract>();
        app.UseContracts().Register<OrdersSynchronizationContract>();
        app.UseContracts().Register<ProductsSynchronizationContract>();
        app.UseContracts().Register<StocksSynchronizationContract>();
    }
}

