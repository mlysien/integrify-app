using Integrify.Integrations.Products.Model;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Products.Port.Driving;

/// <summary>
/// Marker interface for products integration driving port
/// </summary>
public interface IProductsIntegrationDrivingPort : IDrivingPort<ProductIntegrationModel>;