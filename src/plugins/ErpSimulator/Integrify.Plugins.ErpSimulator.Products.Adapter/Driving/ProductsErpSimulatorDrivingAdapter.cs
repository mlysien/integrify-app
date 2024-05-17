using Integrify.Integrations.Products.Port.Driving;
using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Products.Adapter.Driving;

public class ProductsErpSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
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