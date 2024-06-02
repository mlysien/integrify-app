using Integrify.Integrations.Products.Model;
using Integrify.Integrations.Products.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter.Driving;

internal sealed class ProductsShopSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<ProductIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        throw new NotImplementedException();
    }

    public Task<ProductIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        throw new NotImplementedException();
    }
}