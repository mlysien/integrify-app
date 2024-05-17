using Integrify.Integrations.Products.Api.Public;
using Integrify.Integrations.Products.Core.Abstractions;

namespace Integrify.Integrations.Products.Api;

internal sealed class ProductsIntegrationApi(IProductsIntegrationProcess integrationProcess) : IProductsIntegrationApi
{
    public async Task RunIntegration()
    {
        await integrationProcess.ExecuteIntegrationProcess();
    }
}