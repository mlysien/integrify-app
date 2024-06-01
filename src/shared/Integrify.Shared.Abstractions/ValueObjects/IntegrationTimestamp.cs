namespace Integrify.Shared.Abstractions.ValueObjects;

/// <summary>
/// Timestamp of last synchronized integration model entity
/// </summary>
/// <param name="Ticks"></param>
public record IntegrationTimestamp(long Ticks);