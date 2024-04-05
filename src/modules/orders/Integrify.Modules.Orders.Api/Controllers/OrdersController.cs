using Integrify.Modules.Orders.Core.Contracts;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Modules.Orders.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrdersController(IPlugin sourcePlugin) : Controller
{
    // private read only IPlugin input plugin
    [HttpPost]
    [SwaggerOperation("Begin synchronization process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult<string>> Synchronize()
    {
        // fetch orders from e-commerce shop
        var orderD = await sourcePlugin.FetchAsync<OrderSourceData>();
        
        // do something with orders 
        
        // save in db last synchronized order id 
        
        // save fetched orders
        
        
        return await Task.FromResult<ActionResult<string>>(Ok("Here we go!"));
    }
}