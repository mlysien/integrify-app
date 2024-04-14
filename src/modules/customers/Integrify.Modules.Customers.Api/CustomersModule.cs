using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Customers.Api;

public class CustomersModule : IModule
{
    public string Name => "Customers";
    
    public Version? Version => new(0, 0, 1);
    
    public void Register(IServiceCollection services)
    {
        
    }

    public void Use(IApplicationBuilder app)
    {
        
    }
}