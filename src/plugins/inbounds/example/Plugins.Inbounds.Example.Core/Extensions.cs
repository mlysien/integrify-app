using Microsoft.Extensions.DependencyInjection;
using Plugins.Inbounds.Example.Core.Services;
using Plugins.Inbounds.Example.Port.Api;


namespace Plugins.Inbounds.Example.Core;

public static class Extensions
{
    public static void AddInboundPluginCoreLayer(this IServiceCollection servicesCollection)
    {
        servicesCollection.AddTransient<IInboundCustomersApi, InboundCustomersApi>();
        servicesCollection.AddTransient<IInboundOrdersApi, InboundOrdersApi>();
    }
}

