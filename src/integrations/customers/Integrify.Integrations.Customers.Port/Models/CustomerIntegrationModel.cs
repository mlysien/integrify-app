using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Integrations.Customers.Port.Models;

/// <summary>
/// Represents integration model of customer entity 
/// </summary>
public sealed class CustomerIntegrationModel : IIntegrationModel
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public bool IsActive { get; set; }

}