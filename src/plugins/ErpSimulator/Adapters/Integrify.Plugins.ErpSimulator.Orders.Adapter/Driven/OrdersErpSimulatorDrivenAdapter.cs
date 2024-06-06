using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.Time;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driven;

public class OrdersErpSimulatorDrivenAdapter(
    IClock clock,
    IProductRepository productRepository,
    IOrderRepository orderRepository) : IOrdersIntegrationDrivenPort
{
    public async Task PushAsync(OrderIntegrationModel integrationModel)
    {
        var products = new List<Product>();

        foreach (var orderProduct in integrationModel.OrderProducts)
        {
            var product = await productRepository.GetProductAsync(orderProduct.ProductId.Value);
            
            products.Add(product);
        }
        
        var order = new Order()
        {
            Id = integrationModel.Id.Value,
            CreatedAt = integrationModel.CreatedAt,
            OrderStateId = (int)integrationModel.Status,
            UpdatedAt = clock.NowDateTime(),
            Products = products
        };

        await orderRepository.SaveOrderAsync(order);
    }
}