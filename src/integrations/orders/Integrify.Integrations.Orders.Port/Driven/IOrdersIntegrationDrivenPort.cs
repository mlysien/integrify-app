using Integrify.Integrations.Orders.Port.Models;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Orders.Port.Driven;

/// <summary>
/// Marker interface for orders integration driven port
/// </summary>
public interface IOrdersIntegrationDrivenPort : IDrivenPort<OrderIntegrationModel>;