namespace Integrify.Shared.Abstractions.Plugins;

/// <summary>
/// Marker interface for plugins
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Plugin name
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// Plugin type
    /// </summary>
    PluginType Type { get; }
}