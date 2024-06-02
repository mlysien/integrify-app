using Integrify.Integrations.Stocks.Core.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Stocks.Core.Repository;

internal sealed class StocksIntegrationRepository : IStocksIntegrationRepository
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