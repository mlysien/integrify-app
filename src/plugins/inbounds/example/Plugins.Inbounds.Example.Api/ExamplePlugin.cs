using Integrify.Shared.Abstractions.Plugins;

namespace Plugins.Inbounds.Example.Api;

/// <summary>
/// This is an example implementation of inbound type plugin.
/// </summary>
public class ExamplePlugin : IPlugin
{
    public PluginType Type => PluginType.Inbound;

    public string Name => "Example Plugin";
    
    public Task<TResult> FetchAsync<TResult>(CancellationToken cancellationToken = default) where TResult : class, IPluginContract
    {
        throw new NotImplementedException();
    }

    public Task SendAsync<TObject>(TObject contractObject, CancellationToken cancellationToken = default) where TObject : class, IPluginContract
    {
        throw new NotImplementedException();
    }
}