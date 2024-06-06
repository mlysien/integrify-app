using Integrify.Integrations.Orders.Core.Abstractions;
using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Integrations.Orders.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Orders.Core.Process;

internal class OrdersIntegrationProcess(
    ILogger<OrdersIntegrationProcess> logger,
    IOrdersIntegrationRepository repository,
    IOrdersIntegrationDrivingPort drivingPort,
    IOrdersIntegrationDrivenPort drivenPort) 
    : IOrdersIntegrationProcess
{
    public async Task ExecuteIntegrationProcessAsync()
    {
        logger.LogInformation("Orders integration started");

        var lastIntegrationTimestamp = await repository.GetLastIntegrationTimestampAsync();
        var ordersCollection = await drivingPort.FetchCollectionAsync(lastIntegrationTimestamp);

        logger.LogInformation("Received {count} orders", ordersCollection.Count);

        foreach (var orderModel in ordersCollection)
        {
            logger.LogInformation("Processing order with Id: {id}, Created: {date}, " +
                                  "Status: {status}, Products: {count}", 
                orderModel.Id.Value, orderModel.CreatedAt, 
                orderModel.Status, orderModel.OrderProducts.Count);

            await drivenPort.PushAsync(orderModel);
        }

        await repository.UpdateIntegrationTimestampAsync();
        
        logger.LogInformation("Orders integration finished");
    }
}