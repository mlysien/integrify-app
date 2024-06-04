using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories;

public class OrderRepository : IOrderRepository
{
    public async Task SaveOrderAsync(Order order)
    {
        await Task.Delay(new Random().Next(100, 1000));
    }
}