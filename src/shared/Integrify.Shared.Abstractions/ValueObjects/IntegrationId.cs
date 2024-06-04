namespace Integrify.Shared.Abstractions.ValueObjects;

/// <summary>
/// Represents integration model entity unique identifier
/// </summary>
/// <param name="Value">Value of unique identifier</param>
public record IntegrationId(Guid Value);