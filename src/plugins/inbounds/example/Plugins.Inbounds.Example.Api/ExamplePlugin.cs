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
    
    public Task FetchAsync()
    {
        return Task.CompletedTask;
    }
}