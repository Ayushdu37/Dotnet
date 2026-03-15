using JWTAuthentication.Services;
using Microsoft.AspNetCore.Mvc;
using JWTAuthentication.Models;

namespace JWTAuthentication.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest login)
        {
            var token = _authService.Authenticate(login);

            if (token == null)
                return Unauthorized();

            return Ok(new { token });
        }
    }
}
