using Microsoft.AspNetCore.Mvc;
using GreenRoute.Models;

namespace GreenRoute.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    // CRUD endpoints will be implemented in Sprint 4
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Vehicle>> GetVehicle(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<Vehicle>> CreateVehicle(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateVehicle(int id, Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVehicle(int id)
    {
        throw new NotImplementedException();
    }
}