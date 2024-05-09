using Integrify.Modules.Customers.Port.Models;

namespace Integrify.Modules.Customers.Port;

/// <summary>
/// 
/// </summary>
public interface ICustomerSourcePort
{
    Task<IReadOnlyCollection<CustomerModel>> GetCollectionAsync();
}