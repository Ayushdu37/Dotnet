using JWTAuthentication.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTAuthentication.Services
{
    public class AuthService
    {
        private List<User> users = new List<User>
        {
            new User { Username="admin", Password="123", Role="Admin"},
            new User { Username="student", Password="123", Role="Student"}
        };

        private readonly IConfiguration _config;

        public AuthService(IConfiguration config)
        {
            _config = config;
        }

        public string Authenticate(LoginRequest login)
        {
            var user = users.FirstOrDefault(x =>
                x.Username == login.Username &&
                x.Password == login.Password);

            if (user == null)
                return null;

            return GenerateToken(user);
        }

        private string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            var creds = new SigningCredentials(
                key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
