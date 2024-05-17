using Integrify.Integrations.Customers.Port.Models;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Customers.Port.Driving;

/// <summary>
/// Marker interface for customers integration driving port
/// </summary>
public interface ICustomersIntegrationDrivingPort : IDrivingPort<CustomerIntegrationModel>;