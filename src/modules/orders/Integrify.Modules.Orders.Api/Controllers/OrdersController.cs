using Integrify.Shared.Abstractions.Plugins;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Modules.Orders.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrdersController(IInboundPlugin inboundPlugin, IOutboundPlugin outboundPlugin) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin synchronization process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult<string>> Synchronize()
    {
        await inboundPlugin.FetchAsync();
        
        // do something with orders
        
        await outboundPlugin.SaveAsync();
        
        return await Task.FromResult<ActionResult<string>>(Ok("Here we go!"));
    }
}