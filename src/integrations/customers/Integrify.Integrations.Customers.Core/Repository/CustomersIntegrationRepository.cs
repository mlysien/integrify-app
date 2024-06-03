using Integrify.Integrations.Customers.Core.Abstractions;
using Integrify.Shared.Abstractions.Options;
using Integrify.Shared.Abstractions.Time;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Customers.Core.Repository;

internal sealed class CustomersIntegrationRepository(
    IClock clock,
    IIntegrationOptionsProvider integrationOptionsProvider)
    : ICustomersIntegrationRepository
{
    public string IntegrationArea => "customers";

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