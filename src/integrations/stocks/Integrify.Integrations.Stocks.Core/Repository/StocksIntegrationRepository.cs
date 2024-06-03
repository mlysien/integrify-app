using Integrify.Integrations.Stocks.Core.Abstractions;
using Integrify.Shared.Abstractions.Options;
using Integrify.Shared.Abstractions.Time;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Stocks.Core.Repository;

internal sealed class StocksIntegrationRepository(
    IClock clock,
    IIntegrationOptionsProvider integrationOptionsProvider)
    : IStocksIntegrationRepository
{
    public string IntegrationArea => "stocks";

    public async Task<IntegrationTimestamp> GetLastIntegrationTimestampAsync()
    {
        var options = await integrationOptionsProvider.GetIntegrationOptions(IntegrationArea);

        return options.IntegrationTimestamp;
    }

    public async Task UpdateIntegrationTimestampAsync()
    {
        var options = await integrationOptionsProvider.GetIntegrationOptions(IntegrationArea);

        options.IntegrationTimestamp = new IntegrationTimestamp(clock.NowTicks());

        await integrationOptionsProvider.UpdateIntegrationOptions(IntegrationArea, options);
    }
}