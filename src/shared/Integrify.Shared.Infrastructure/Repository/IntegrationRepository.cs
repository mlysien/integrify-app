using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Time;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Shared.Infrastructure.Repository;

public sealed class IntegrationRepository(IClock clock) : IIntegrationRepository
{
    public async Task<IntegrationTimestamp> GetLastIntegrationTimestamp(string integrationArea)
    {
        

        
        // todo parse
        
        return new IntegrationTimestamp(clock.NowTicks());
    }

    public Task UpdateLastIntegrationTimestamp()
    {
        return Task.CompletedTask;
    }
}