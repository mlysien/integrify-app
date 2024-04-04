using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Modules.Orders.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : Controller
{
    [HttpGet]
    [SwaggerOperation("Begin synchronization process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public Task<ActionResult<string>> Synchronize()
    {
        return Task.FromResult<ActionResult<string>>(Ok("   Here we go!"));
    }
}