using Integrify.Integrations.Orders.Core.Abstractions;
using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Orders.Core.Process;

internal class OrdersIntegrationProcess(
    ILogger<OrdersIntegrationProcess> logger,
    IIntegrationRepository integrationRepository,
    IOrdersIntegrationDrivingPort drivingPort,
    IOrdersIntegrationDrivenPort drivenPort) 
    : IOrdersIntegrationProcess
{
    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Orders integration started");

        var lastIntegrationTimestamp = await integrationRepository.GetLastIntegrationTimestamp("orders");
        var ordersCollection = await drivingPort.FetchCollectionAsync(lastIntegrationTimestamp);

        logger.LogInformation("Received {count} orders", ordersCollection.Count);

        foreach (var orderModel in ordersCollection)
        {
            logger.LogInformation("Processing order with Id: {id}, createdAt: {date}", 
                orderModel.Id, orderModel.CreatedAt);

            await drivenPort.PushAsync(orderModel);
        }

        await integrationRepository.UpdateLastIntegrationTimestamp();
    }
}