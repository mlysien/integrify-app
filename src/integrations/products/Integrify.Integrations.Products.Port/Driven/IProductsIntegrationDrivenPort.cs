using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Integrations.Products.Port.Driven;

public interface IProductsIntegrationDrivenPort
{
    Task SaveProductAsync(ProductIntegrationModel productIntegrationModel);
}