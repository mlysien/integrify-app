using Integrify.Modules.Orders.Core.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Modules.Orders.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
internal class OrdersController(IDispatcher dispatcher) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin orders synchronization process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize(SynchronizeOrders command)
    {
        await dispatcher.SendAsync(command);
        
        return Ok();
    }
}