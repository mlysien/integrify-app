using Integrify.Integrations.Products.Port.Driving;
using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter.Driving;

internal sealed class ProductsShopSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<ProductIntegrationModel>> GetProductsCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductIntegrationModel> GetSingleProductAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}