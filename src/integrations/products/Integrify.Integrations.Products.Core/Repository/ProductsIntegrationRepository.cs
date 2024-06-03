using Integrify.Integrations.Products.Core.Abstractions;
using Integrify.Shared.Abstractions.Options;
using Integrify.Shared.Abstractions.Time;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Products.Core.Repository;

internal sealed class ProductsIntegrationRepository(
    IClock clock,
    IIntegrationOptionsProvider integrationOptionsProvider)
    : IProductsIntegrationRepository
{
    public string IntegrationArea => "products";

    public async Task<IntegrationTimestamp> GetLastIntegrationTimestampAsync()
    {
        var options = await integrationOptionsProvider.GetIntegrationOptionsAsync(IntegrationArea);

        return options.IntegrationTimestamp;
    }

    public async Task UpdateIntegrationTimestampAsync()
    {
        var options = await integrationOptionsProvider.GetIntegrationOptionsAsync(IntegrationArea);

        options.IntegrationTimestamp = new IntegrationTimestamp(clock.NowTicks());

        await integrationOptionsProvider.UpdateIntegrationOptionsAsync(IntegrationArea, options);
    }
}