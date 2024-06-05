using Integrify.Integrations.Customers.Model.Enums;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Customers.Model;

/// <summary>
/// Represents integration model of customer entity 
/// </summary>
public sealed class CustomerIntegrationModel : IIntegrationModel
{
    public IntegrationId Id { get; set; }
    
    public required string Name { get; set; }

    public bool IsActive { get; set; }

    public CustomerType CustomerType { get; set; }
}