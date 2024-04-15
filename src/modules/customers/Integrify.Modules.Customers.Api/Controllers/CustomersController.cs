using Integrify.Modules.Customers.Core.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Modules.Customers.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
internal class CustomersController(IDispatcher dispatcher) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin customers synchronization process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize(SynchronizeCustomers command)
    {
        await dispatcher.SendAsync(command);
        
        return Ok();
    }
}