using Integrify.Shared.Abstractions.Plugins;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Plugins.FakeErp.Api;

public class FakeErpPlugin : IPlugin
{
    public string Name => "FakeERP plugin";
    public void Register(IServiceCollection services)
    {
    }

    public void Use(IApplicationBuilder app)
    {
    }
}