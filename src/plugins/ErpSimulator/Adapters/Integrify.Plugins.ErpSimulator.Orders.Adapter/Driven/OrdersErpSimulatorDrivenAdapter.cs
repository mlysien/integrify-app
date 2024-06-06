using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driven;

public class OrdersErpSimulatorDrivenAdapter(IOrderRepository repository) : IOrdersIntegrationDrivenPort
{
    public async Task PushAsync(OrderIntegrationModel integrationModel)
    {
        var order = new Order()
        {
            Id = integrationModel.Id.Value,
            CreatedAt = integrationModel.CreatedAt,
            OrderStateId = (int)integrationModel.Status
        };

        await repository.SaveOrderAsync(order);
    }
}