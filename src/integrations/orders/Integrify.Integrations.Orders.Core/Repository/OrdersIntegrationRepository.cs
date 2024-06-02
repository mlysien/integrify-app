using Integrify.Integrations.Orders.Core.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Orders.Core.Repository;

internal sealed class OrdersIntegrationRepository : IOrdersIntegrationRepository
{
    public Task<IntegrationTimestamp> GetLastIntegrationTimestamp()
    {
        throw new NotImplementedException();
    }

    public Task UpdateLastIntegrationTimestamp(IntegrationTimestamp timestamp)
    {
        throw new NotImplementedException();
    }
}