using Integrify.Integrations.Products.Port.Driving;
using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter.Driving;

internal sealed class ProductsShopSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<ProductModel>> GetProductsCollection()
    {
        throw new NotImplementedException();
    }

    public Task<ProductModel> GetSingleProduct(Guid id)
    {
        throw new NotImplementedException();
    }
}