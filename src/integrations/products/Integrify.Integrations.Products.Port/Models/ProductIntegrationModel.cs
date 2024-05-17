using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Integrations.Products.Port.Models;

/// <summary>
/// Represents integration model of product entity 
/// </summary>
public sealed class ProductIntegrationModel : IIntegrationModel
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public double Price { get; set; }
}