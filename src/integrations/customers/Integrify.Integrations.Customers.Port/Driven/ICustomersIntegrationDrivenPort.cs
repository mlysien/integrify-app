using Integrify.Integrations.Customers.Model;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Customers.Port.Driven;

/// <summary>
/// Marker interface for customers integration driven port
/// </summary>
public interface ICustomersIntegrationDrivenPort : IDrivenPort<CustomerIntegrationModel>;