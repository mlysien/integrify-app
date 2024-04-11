using Integrify.Shared.Abstractions.Plugins;
using Microsoft.Extensions.Logging;

namespace Plugins.Inbounds.Example.Api;

/// <summary>
/// This is an example implementation of inbound type plugin.
/// </summary>
public class ExamplePlugin : IInboundPlugin
{
    public string Name => "Example Plugin";

    public PluginType Type => PluginType.Inbound;
    
    public Task<IEnumerable<object>> FetchAsync()
    {
        // todo get data from external source like some Shop API
        throw new NotImplementedException();
    }
}