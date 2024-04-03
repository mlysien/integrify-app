using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Order;

public class OrderModule : IModule
{
    public string Name => "Order";
    
    public Version? Version => new(0, 0, 1);
    
    public void Use(IApplicationBuilder app)
    {
       
    }

    public void Register(IServiceCollection services)
    {
    }
}