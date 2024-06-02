namespace Integrify.Shared.Abstractions.ValueObjects;

/// <summary>
/// Timestamp of last synchronized integration model entity
/// </summary>
/// <param name="Ticks">Count of ticks</param>
public record IntegrationTimestamp(long Ticks);