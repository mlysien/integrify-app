using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Products.Api;

public class ProductsModule : IModule
{
    public string Name => "Products";
    
    public Version? Version => new(0, 0, 1);
    
    public void Register(IServiceCollection services)
    {
        
    }

    public void Use(IApplicationBuilder app)
    {

    }
}