using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Shared.Abstractions.Options;

public class IntegrationOptions
{
    public IntegrationTimestamp IntegrationTimestamp { get; set; } = new(DateTime.MinValue.Ticks);
}