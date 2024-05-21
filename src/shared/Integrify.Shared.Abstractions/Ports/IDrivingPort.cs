using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Shared.Abstractions.Ports;

/// <summary>
/// Interface for marks driving ports based on integration model
/// </summary>
/// <typeparam name="T">Integration model</typeparam>
public interface IDrivingPort<T> where T: class, IIntegrationModel
{
    /// <summary>
    /// Fetch collection of integration models
    /// </summary>
    Task<IReadOnlyCollection<T>> FetchCollectionAsync();

    /// <summary>
    /// Get single integration model
    /// </summary>
    /// <param name="id">Unique identifier of integration model</param>
    Task<T> GetSingleAsync(Guid id);
}