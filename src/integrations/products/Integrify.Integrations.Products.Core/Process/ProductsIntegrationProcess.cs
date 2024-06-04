using Integrify.Integrations.Products.Core.Abstractions;
using Integrify.Integrations.Products.Port.Driven;
using Integrify.Integrations.Products.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Products.Core.Process;

internal sealed class ProductsIntegrationProcess(
    ILogger<ProductsIntegrationProcess> logger,
    IProductsIntegrationRepository repository,
    IProductsIntegrationDrivingPort drivingPort,
    IProductsIntegrationDrivenPort drivenPort) 
    : IProductsIntegrationProcess
{
    public async Task ExecuteIntegrationProcessAsync()
    {
        logger.LogInformation("Products integration started");

        var timestamp = await repository.GetLastIntegrationTimestampAsync();
        var productsCollection = await drivingPort.FetchCollectionAsync(timestamp);

        logger.LogInformation("Received {count} products", productsCollection.Count);

        foreach (var productModel in productsCollection)
        {
            logger.LogInformation("Processing product with Id: {id}, Name: {name}", 
                productModel.Id.Value, productModel.Name);

            await drivenPort.PushAsync(productModel);
        }

        await repository.UpdateIntegrationTimestampAsync();
        
        logger.LogInformation("Products integration finished");
    }
}