using Integrify.Integrations.Stocks.Core.Services;
using Integrify.Integrations.Stocks.Port.Driven;
using Integrify.Integrations.Stocks.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Stocks.Core.Process;

internal sealed class StocksIntegrationProcess(
    ILogger<StocksIntegrationProcess> logger,
    IStocksIntegrationDrivingPort drivingPort,
    IStocksIntegrationDrivenPort drivenPort) : IStocksIntegrationProcess
{
    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Stocks integration started");
        
        var stocksCollection = await drivingPort.GetStocksCollectionAsync();

        logger.LogInformation("Received {count} stocks", stocksCollection.Count);

        foreach (var stockModel in stocksCollection)
        {
            logger.LogInformation("Processing stock with Id: {id}, Amount: {amount}", 
                stockModel.Id, stockModel.Amount);

            await drivenPort.SaveStockAsync(stockModel);
        }
    }
}