using Integrify.Integrations.Customers.Core.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Customers.Core.Repository;

internal sealed class CustomersIntegrationRepository : ICustomersIntegrationRepository
{
    public Task<IntegrationTimestamp> GetLastIntegrationTimestamp()
    {
        // read this from config file...
        
        return Task.Run(() => new IntegrationTimestamp(DateTime.MinValue.Ticks));
    }

    public Task UpdateLastIntegrationTimestamp(IntegrationTimestamp timestamp)
    {
        // write this to config file...
        
        return Task.CompletedTask;
    }
}