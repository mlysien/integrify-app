using Integrify.Plugins.Shops.TemplateShop.Adapter;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.Shops.TemplateShop.Api;

public class TemplateShopPlugin : IPlugin
{
    public string Name => "Template Plugin";
    
    public void Register(IServiceCollection serviceCollection)
    {
        serviceCollection.AddAdapterLayer();
    }

    public void Use(IApplicationBuilder applicationBuilder)
    {
    }
}