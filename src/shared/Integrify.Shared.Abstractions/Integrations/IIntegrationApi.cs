namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Interface provide integration API methods
/// </summary>
public interface IIntegrationApi
{
    /// <summary>
    /// Method run integration
    /// </summary>
    Task RunIntegrationAsync();
}