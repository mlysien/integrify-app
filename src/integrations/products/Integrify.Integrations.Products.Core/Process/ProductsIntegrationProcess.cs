using Integrify.Integrations.Products.Core.Abstractions;
using Integrify.Integrations.Products.Port.Driven;
using Integrify.Integrations.Products.Port.Driving;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Products.Core.Process;

internal sealed class ProductsIntegrationProcess(
    ILogger<ProductsIntegrationProcess> logger,
    IIntegrationRepository integrationRepository,
    IProductsIntegrationDrivingPort drivingPort,
    IProductsIntegrationDrivenPort drivenPort) 
    : IProductsIntegrationProcess
{
    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Products integration started");

        var lastIntegrationTimestamp = await integrationRepository.GetLastIntegrationTimestamp("products");
        var productsCollection = await drivingPort.FetchCollectionAsync(lastIntegrationTimestamp);

        logger.LogInformation("Received {count} products", productsCollection.Count);

        foreach (var productModel in productsCollection)
        {
            logger.LogInformation("Processing product with Id: {id}, Name: {name}", 
                productModel.Id, productModel.Name);

            await drivenPort.PushAsync(productModel);
        }

        await integrationRepository.UpdateLastIntegrationTimestamp();
    }
}