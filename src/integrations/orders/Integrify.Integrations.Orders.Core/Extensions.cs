using Integrify.Integrations.Orders.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Orders.Core;

public static class Extensions
{
    public static void AddIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IOrdersIntegration, OrdersIntegration>();
    }
}