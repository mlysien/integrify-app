using Integrify.Integrations.Products.Api.Public;
using Integrify.Integrations.Products.Core.Services;

namespace Integrify.Integrations.Products.Api.Services;

internal sealed class ProductsIntegrationApi(IProductsIntegrationProcess integrationProcess) : IProductsIntegrationApi
{
    public async Task RunIntegration()
    {
        await integrationProcess.ExecuteOrdersIntegrationProcess();
    }
}