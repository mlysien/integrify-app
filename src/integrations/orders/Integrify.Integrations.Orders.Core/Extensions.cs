using Integrify.Integrations.Orders.Core.Process;
using Integrify.Integrations.Orders.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Orders.Core;

public static class Extensions
{
    public static void AddOrdersIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IOrdersIntegrationProcess, OrdersIntegrationProcess>();
    }
}