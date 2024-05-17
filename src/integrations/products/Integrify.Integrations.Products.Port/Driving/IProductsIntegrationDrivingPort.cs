using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Integrations.Products.Port.Driving;

public interface IProductsIntegrationDrivingPort
{
    Task<IReadOnlyCollection<ProductIntegrationModel>> GetProductsCollectionAsync();

    Task<ProductIntegrationModel> GetSingleProductAsync(Guid id);
}