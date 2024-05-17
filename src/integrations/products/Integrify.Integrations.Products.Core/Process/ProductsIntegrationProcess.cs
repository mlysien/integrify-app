using Integrify.Integrations.Products.Core.Abstractions;
using Integrify.Integrations.Products.Port.Driven;
using Integrify.Integrations.Products.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Products.Core.Process;

internal sealed class ProductsIntegrationProcess(
    ILogger<ProductsIntegrationProcess> logger,
    IProductsIntegrationDrivingPort drivingPort,
    IProductsIntegrationDrivenPort drivenPort) : IProductsIntegrationProcess
{
    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Products integration started");
        
        var productsCollection = await drivingPort.GetProductsCollectionAsync();

        logger.LogInformation("Received {count} products", productsCollection.Count);

        foreach (var productModel in productsCollection)
        {
            logger.LogInformation("Processing product with Id: {id}, Name: {name}", 
                productModel.Id, productModel.Name);

            await drivenPort.SaveProductAsync(productModel);
        }
    }
}