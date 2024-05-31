using Integrify.Integrations.Orders.Model;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Orders.Port.Driving;

/// <summary>
/// Marker interface for orders integration driving port
/// </summary>
public interface IOrdersIntegrationDrivingPort : IDrivingPort<OrderIntegrationModel>;