using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Integrations.Orders.Port.Driven;

/// <summary>
/// 
/// </summary>
public interface IOrdersIntegrationDrivenPort
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="orderModel"></param>
    Task SaveOrderAsync(OrderModel orderModel);
}