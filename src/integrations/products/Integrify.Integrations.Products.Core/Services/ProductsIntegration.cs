using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Products.Core.Services;

internal sealed class ProductsIntegration(ILogger<ProductsIntegration> logger) : IProductsIntegration
{
    public async Task RunIntegration()
    {
        logger.LogInformation("Products integration started");
    }
}