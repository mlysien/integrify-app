using Integrify.Integrations.Products.Port.Driven;
using Integrify.Plugins.ShopSimulator.Products.Adapter.Driven;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter;

public static class Extensions
{
    public static void AddProductsAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsIntegrationDrivenPort, ProductsShopSimulatorDrivenAdapter>();
    }
}