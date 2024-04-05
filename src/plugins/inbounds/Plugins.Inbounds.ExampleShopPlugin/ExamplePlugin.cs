using Integrify.Shared.Abstractions.Plugins;

namespace Plugins.Inbounds.ExampleShopPlugin;

public class ExamplePlugin : IPlugin
{
    public PluginType Type => PluginType.Inbound;
    public string Name => "Example Inbound Plugin";
    
    public Task<TResult> FetchAsync<TResult>(CancellationToken cancellationToken = default) where TResult : class, IPluginContract
    {
        throw new NotImplementedException();
    }

    public Task SendAsync<TObject>(TObject contractObject, CancellationToken cancellationToken = default) where TObject : class, IPluginContract
    {
        throw new NotImplementedException();
    }
}