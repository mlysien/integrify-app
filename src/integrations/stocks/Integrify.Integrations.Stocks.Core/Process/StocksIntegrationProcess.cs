using Integrify.Integrations.Stocks.Core.Abstractions;
using Integrify.Integrations.Stocks.Port.Driven;
using Integrify.Integrations.Stocks.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Stocks.Core.Process;

internal sealed class StocksIntegrationProcess(
    ILogger<StocksIntegrationProcess> logger,
    IStocksIntegrationRepository repository,
    IStocksIntegrationDrivingPort drivingPort,
    IStocksIntegrationDrivenPort drivenPort) : IStocksIntegrationProcess
{
    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Stocks integration started");

        var timestamp = await repository.GetLastIntegrationTimestampAsync();
        var stocksCollection = await drivingPort.FetchCollectionAsync(timestamp);

        logger.LogInformation("Received {count} stocks", stocksCollection.Count);

        foreach (var stockModel in stocksCollection)
        {
            logger.LogInformation("Processing stock with Id: {id}, Amount: {amount}", 
                stockModel.Id, stockModel.Amount);

            await drivenPort.PushAsync(stockModel);
        }

        await repository.UpdateIntegrationTimestampAsync();
    }
}