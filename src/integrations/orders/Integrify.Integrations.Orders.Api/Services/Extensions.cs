using Integrify.Integrations.Orders.Api.Public;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Orders.Api.Services;

internal static class Extensions
{
    public static void AddOrdersIntegrationApi(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IOrdersIntegrationApi, OrdersIntegrationApi>();
    }
}