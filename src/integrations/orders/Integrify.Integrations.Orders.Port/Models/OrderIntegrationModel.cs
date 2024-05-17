using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Integrations.Orders.Port.Models;

/// <summary>
/// Represents integration model of order entity 
/// </summary>
public sealed class OrderIntegrationModel : IIntegrationModel
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }
}