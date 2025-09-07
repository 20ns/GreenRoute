using Microsoft.AspNetCore.Mvc;
using GreenRoute.Models;
using GreenRoute.Services;

namespace GreenRoute.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoutesController : ControllerBase
{
    // Route optimization endpoint will be implemented in Sprint 4

    [HttpPost("optimize")]
    public async Task<ActionResult<OptimizedRoute>> OptimizeRoute(RouteRequest request)
    {
        throw new NotImplementedException();
    }
}