namespace Integrify.Shared.Abstractions.Plugins;

/// <summary>
/// Marker interface for plugins
/// </summary>
public interface IPlugin<in TContractObject> where TContractObject : class, IPluginContract
{
    /// <summary>
    /// Plugin name
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// Fetch data from plugin source
    /// </summary>
    /// <param name="cancellationToken"></param>
    Task<TResult> FetchAsync<TResult>(CancellationToken cancellationToken = default) where TResult : class, IPluginContract;
    
    /// <summary>
    /// Send data to plugin source
    /// </summary>
    /// <param name="contractObject"></param>
    /// <param name="cancellationToken"></param>
    Task SendAsync<TObject>(TObject contractObject, CancellationToken cancellationToken = default) where TObject : class, IPluginContract;
}