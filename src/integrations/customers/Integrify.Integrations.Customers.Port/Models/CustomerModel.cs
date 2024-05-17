namespace Integrify.Integrations.Customers.Port.Models;

/// <summary>
/// 
/// </summary>
public sealed class CustomerModel
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }
}