using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Integrations.Products.Port.Driving;

public interface IProductsIntegrationDrivingPort
{
    Task<IReadOnlyCollection<ProductModel>> GetProductsCollection();

    Task<ProductModel> GetSingleProduct(Guid id);
}