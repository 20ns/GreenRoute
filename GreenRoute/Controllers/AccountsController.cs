using Microsoft.AspNetCore.Mvc;
using GreenRoute.Models;

namespace GreenRoute.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    // Authentication endpoints will be implemented in Sprint 5

    [HttpPost("register")]
    public async Task<ActionResult> Register(RegisterRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginRequest request)
    {
        throw new NotImplementedException();
    }
}

public class RegisterRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class LoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}