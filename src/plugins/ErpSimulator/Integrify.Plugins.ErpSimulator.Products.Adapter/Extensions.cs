using Integrify.Integrations.Products.Port.Driving;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ErpSimulator.Products.Adapter;

public static class Extensions
{
    public static void AddProductsAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsIntegrationDrivingPort, IProductsIntegrationDrivingPort>();
    }
}