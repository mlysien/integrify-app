using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Shared.Abstractions.Ports;

/// <summary>
/// Interface for marks driven ports based on integration model
/// </summary>
/// <typeparam name="T">Integration model</typeparam>
public interface IDrivenPort<in T> where T: class, IIntegrationModel
{
    /// <summary>
    /// Push integration model out of port
    /// </summary>
    /// <param name="integrationModel">Integration model</param>
    Task PushAsync(T integrationModel);
}