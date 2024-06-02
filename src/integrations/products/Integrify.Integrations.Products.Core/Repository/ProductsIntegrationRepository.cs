using Integrify.Integrations.Products.Core.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Products.Core.Repository;

internal sealed class ProductsIntegrationRepository : IProductsIntegrationRepository
{
    public Task<IntegrationTimestamp> GetLastIntegrationTimestamp()
    {
        throw new NotImplementedException();
    }

    public Task UpdateLastIntegrationTimestamp(IntegrationTimestamp timestamp)
    {
        throw new NotImplementedException();
    }
}