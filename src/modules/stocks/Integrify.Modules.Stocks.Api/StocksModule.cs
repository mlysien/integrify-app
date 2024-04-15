using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Stocks.Api;

public class StocksModule : IModule
{
    public string Name => "Stocks";
    
    public Version? Version => new(0, 0, 1);
    
    public void Register(IServiceCollection services)
    {
        
    }

    public void Use(IApplicationBuilder app)
    {

    }
}