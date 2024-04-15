using Integrify.Shared.Abstractions.Plugins;
using Integrify.Shared.Infrastructure.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Plugins.Inbounds.Example.Core;
using Plugins.Inbounds.Example.Core.Contracts;

namespace Plugins.Inbounds.Example.Api;

/// <summary>
/// This is an example implementation of inbound type plugin.
/// </summary>
public class ExamplePlugin : IInboundPlugin
{
    public string Name => "Example Plugin";

    public PluginType Type => PluginType.Inbound;
    
    public void Register(IServiceCollection serviceCollection)
    {
        serviceCollection.AddCoreLayer();
    }

    public void Use(IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseCoreLayer();
    }
}