using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FreakyFashion.Areas.API.Controllers
{
    // /api/token
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly UserManager<FreakyFashionUser> userManager;
        private readonly IConfiguration configuration;

        public TokenController(UserManager<FreakyFashionUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        /// <summary>
        /// Generates a JWT token.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Token
        ///     {
        ///         "username": "test@nomail.com"
        ///         "password": "Secret123!"
        ///     }
        ///     
        /// </remarks>
        /// <param name="credentials">Request body containing username and password</param>
        /// <returns>A generated JWT token</returns>
        /// <response code="200">Returns the generated token</response>
        /// <response code="401">If failed login atempt</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult> Create([FromBody]Credentials credentials)
        {
            var user = await userManager.FindByNameAsync(credentials.UserName);
            var hasAccess = await userManager.CheckPasswordAsync(user, credentials.Password);

            if (!hasAccess)
            {
                return Unauthorized(); //401 Unauthorized
            }

            var token = GenerateToken(user);

            return Ok(token);
        }

        private Token GenerateToken(FreakyFashionUser user)
        {
            var signingKey = Convert.FromBase64String(configuration["Token:SigningKey"]);
            var expirationInMinutes = double.Parse(configuration["Token:ExpirationInMinutes"]);

            var claims = new ClaimsIdentity(new List<Claim>
            {
                new Claim("userId", user.Id.ToString()),
            });

            var isAdministrator = userManager.IsInRoleAsync(user, "Administrator").Result;

            if (isAdministrator)
            {
                claims.AddClaim(new Claim("admin", "true"));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // iat - Issued At Time
                IssuedAt = DateTime.UtcNow,
                
                // exp - Expiration Time
                Expires = DateTime.UtcNow.AddMinutes(expirationInMinutes),
                Subject = claims,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(signingKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = jwtTokenHandler.CreateJwtSecurityToken(tokenDescriptor);
            var token = new Token
            {
                Value = jwtTokenHandler.WriteToken(jwtSecurityToken)
            };

            return token;
        }

        public class Token
        {
            public string Value { get; set; }
        }

        public class Credentials
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
