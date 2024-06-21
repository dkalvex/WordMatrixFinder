using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Api.Controllers;

/// <summary>
///     Base controller for CQRSProject.
/// </summary>

[ApiController]
[Route("api/[controller]")]
[Consumes("application/json")]
[Produces("application/json")]
public abstract class BaseController : ControllerBase
{
    protected ActionResult<TResult> OkOrNotFound<TResult>(TResult result)
        => result is null ? NotFound() : Ok(result);
}