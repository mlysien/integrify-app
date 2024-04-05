using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Orders.Api;

public class OrdersModule : IModule
{
    public string Name => "Orders";
    
    public Version? Version => new(0, 0, 1);
    
    public void Use(IApplicationBuilder app)
    {
       
    }

    public void Register(IServiceCollection services)
    {
        // todo register 
    }
}