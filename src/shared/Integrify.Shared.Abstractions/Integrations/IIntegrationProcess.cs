namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Interface provide method for use in integration process
/// </summary>
public interface IIntegrationProcess
{
    /// <summary>
    /// Execute integration process
    /// </summary>
    /// <returns></returns>
    Task ExecuteIntegrationProcess();
}