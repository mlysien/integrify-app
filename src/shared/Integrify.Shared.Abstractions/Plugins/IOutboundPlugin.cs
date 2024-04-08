namespace Integrify.Shared.Abstractions.Plugins;

/// <summary>
/// Represents outbound type plugin
/// </summary>
public interface IOutboundPlugin : IPlugin
{
    /// <summary>
    /// Save data using plugin persistence layer
    /// </summary>
    /// <returns></returns>
    Task SaveAsync();
}