using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica.Date;
using Practica.DTOs;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Practica.Date.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Practica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]

    public class AccountController : ControllerBase
    {
        private readonly SocialMediaDb _db;
        private readonly IConfiguration _config;

        public AccountController(SocialMediaDb db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginDTO payload)
        {
            string base64hashedPasswordBytes;
            using (var sha256 = SHA256.Create()) {
                var passwordBytes = Encoding.UTF8.GetBytes(payload.Password);
                var hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                base64hashedPasswordBytes = Convert.ToBase64String(hashedPasswordBytes);
            }
            var existingUser = _db.Users
                    .Where(u => u.Email == payload.UserName
                    && u.HashedPassword == base64hashedPasswordBytes)
                    .SingleOrDefault();

            if (existingUser is null)
            {
                return NotFound();
            }
            else
            {
                var jwt = GenerateJSONWebToken(existingUser);

                return new JsonResult(new {jwt});
            }
        }

        private string GenerateJSONWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }

}
