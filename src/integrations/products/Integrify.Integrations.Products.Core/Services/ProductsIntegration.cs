using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Products.Core.Services;

internal sealed class ProductsIntegration(ILogger<ProductsIntegration> logger) : IProductsIntegration
{
    public Task RunIntegration()
    {
        logger.LogInformation("Products integration started");
        
        return Task.CompletedTask;
    }
}