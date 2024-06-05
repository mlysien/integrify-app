using Integrify.Integrations.Orders.Model.Enums;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Orders.Model;

/// <summary>
/// Represents integration model of order entity 
/// </summary>
public sealed class OrderIntegrationModel : IIntegrationModel
{
    public IntegrationId Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public OrderStatus Status { get; set; }
}