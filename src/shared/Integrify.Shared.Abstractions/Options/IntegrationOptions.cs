using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Shared.Abstractions.Options;

/// <summary>
/// Base model of integration options entity
/// </summary>
public class IntegrationOptions
{
    /// <summary>
    /// Returns timestamp of last integration 
    /// </summary>
    public IntegrationTimestamp IntegrationTimestamp { get; set; } = new(DateTime.MinValue.Ticks);
}