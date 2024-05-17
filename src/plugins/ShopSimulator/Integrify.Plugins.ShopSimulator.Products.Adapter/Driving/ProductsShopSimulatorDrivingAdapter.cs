using Integrify.Integrations.Products.Port.Driving;
using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter.Driving;

internal sealed class ProductsShopSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<ProductIntegrationModel>> FetchCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductIntegrationModel> GetSingleAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}