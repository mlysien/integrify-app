using Integrify.Integrations.Products.Port.Driven;
using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter.Driven;

internal sealed class ProductsShopSimulatorDrivenAdapter : IProductsIntegrationDrivenPort
{
    public Task PushAsync(ProductIntegrationModel integrationModel)
    {
        return Task.CompletedTask;
    }
}