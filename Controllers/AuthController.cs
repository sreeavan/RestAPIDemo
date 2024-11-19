using UserApi.Services;

namespace UserApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly JwtTokenService _jwtTokenService;

    public AuthController(JwtTokenService jwtTokenService)
    {
        _jwtTokenService = jwtTokenService;
    }

    // Dummy login endpoint
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        // Dummy user validation
        if (loginRequest.Username == "testuser" && loginRequest.Password == "password123")
        {
            // Generate a JWT token for the user
            var token = _jwtTokenService.GenerateJwtToken("12345"); // Use a unique user identifier
            return Ok(new
            {
                Token = token,
                Message = "Login successful"
            });
        }

        return Unauthorized("Invalid username or password");
    }
}

// Model for login request
public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
