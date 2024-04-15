using Integrify.Modules.Products.Core.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Modules.Products.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
internal class ProductsController(IDispatcher dispatcher) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin products synchronization process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize(SynchronizeProducts command)
    {
        await dispatcher.SendAsync(command);
        
        return Ok();
    }
}