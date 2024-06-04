using Integrify.Integrations.Products.Model;
using Integrify.Integrations.Products.Port.Driven;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter.Driven;

internal sealed class ProductsShopSimulatorDrivenAdapter : IProductsIntegrationDrivenPort
{
    public Task PushAsync(ProductIntegrationModel integrationModel)
    {
        return Task.CompletedTask;
    }
}