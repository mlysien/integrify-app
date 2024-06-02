using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Interface provide method for use in integration process
/// </summary>
public interface IIntegrationProcess
{
    /// <summary>
    /// Timestamp of last integration
    /// </summary>
    IntegrationTimestamp LastIntegrationTimestamp { get; }
    
    /// <summary>
    /// Execute integration process
    /// </summary>
    /// <returns></returns>
    Task ExecuteIntegrationProcess();
}