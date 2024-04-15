using Integrify.Modules.Stocks.Core.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Modules.Stocks.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
internal class StocksController(IDispatcher dispatcher) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin stocks synchronization process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize(SynchronizeStocks command)
    {
        await dispatcher.SendAsync(command);
        
        return Ok();
    }
}