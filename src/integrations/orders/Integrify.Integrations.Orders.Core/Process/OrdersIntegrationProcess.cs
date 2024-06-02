using Integrify.Integrations.Orders.Core.Abstractions;
using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Orders.Core.Process;

internal class OrdersIntegrationProcess(
    ILogger<OrdersIntegrationProcess> logger,
    IOrdersIntegrationDrivingPort drivingPort,
    IOrdersIntegrationDrivenPort drivenPort) : IOrdersIntegrationProcess
{
    public IntegrationTimestamp LastIntegrationTimestamp { get; }

    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Orders integration started");

        var ordersCollection = await drivingPort.FetchCollectionAsync(LastIntegrationTimestamp);

        logger.LogInformation("Received {count} orders", ordersCollection.Count);

        foreach (var orderModel in ordersCollection)
        {
            logger.LogInformation("Processing order with Id: {id}, createdAt: {date}", 
                orderModel.Id, orderModel.CreatedAt);

            await drivenPort.PushAsync(orderModel);
        }
    }
}