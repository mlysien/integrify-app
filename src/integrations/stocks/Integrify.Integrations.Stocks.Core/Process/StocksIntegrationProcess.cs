using Integrify.Integrations.Stocks.Core.Abstractions;
using Integrify.Integrations.Stocks.Port.Driven;
using Integrify.Integrations.Stocks.Port.Driving;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Stocks.Core.Process;

internal sealed class StocksIntegrationProcess(
    ILogger<StocksIntegrationProcess> logger,
    IIntegrationRepository integrationRepository,
    IStocksIntegrationDrivingPort drivingPort,
    IStocksIntegrationDrivenPort drivenPort) : IStocksIntegrationProcess
{
    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Stocks integration started");

        var lastIntegrationTimestamp = await integrationRepository.GetLastIntegrationTimestamp("stocks");
        var stocksCollection = await drivingPort.FetchCollectionAsync(lastIntegrationTimestamp);

        logger.LogInformation("Received {count} stocks", stocksCollection.Count);

        foreach (var stockModel in stocksCollection)
        {
            logger.LogInformation("Processing stock with Id: {id}, Amount: {amount}", 
                stockModel.Id, stockModel.Amount);

            await drivenPort.PushAsync(stockModel);
        }

        await integrationRepository.UpdateLastIntegrationTimestamp();
    }
}