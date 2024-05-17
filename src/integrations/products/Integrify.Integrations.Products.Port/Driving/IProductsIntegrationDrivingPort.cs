using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Integrations.Products.Port.Driving;

public interface IProductsIntegrationDrivingPort
{
    Task<IReadOnlyCollection<ProductModel>> GetProductsCollectionAsync();

    Task<ProductModel> GetSingleProductAsync(Guid id);
}