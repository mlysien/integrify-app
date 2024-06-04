using Integrify.Plugins.ShopSimulator.Domain.Models;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

public interface IOrderRepository
{
    Task<List<Order>> GetOrdersAsync();
    
    Task<Order> GetOrderAsync(Guid id);
}