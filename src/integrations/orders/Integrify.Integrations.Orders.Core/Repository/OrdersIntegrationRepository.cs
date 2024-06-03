using Integrify.Integrations.Orders.Core.Abstractions;
using Integrify.Shared.Abstractions.Options;
using Integrify.Shared.Abstractions.Time;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Orders.Core.Repository;

internal sealed class OrdersIntegrationRepository(
    IClock clock,
    IIntegrationOptionsProvider integrationOptionsProvider)
    : IOrdersIntegrationRepository
{
    public string IntegrationArea => "orders";

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