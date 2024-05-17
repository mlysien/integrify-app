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
    /// <param name="orderIntegrationModel"></param>
    Task SaveOrderAsync(OrderIntegrationModel orderIntegrationModel);
}