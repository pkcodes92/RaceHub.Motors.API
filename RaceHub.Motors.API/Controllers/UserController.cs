// <copyright file="UserController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.IdentityModel.Tokens;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class represents the necessary methods to log a user into the system.
    /// </summary>
    /// <param name="configuration">The configuration settings.</param>
    /// <param name="userSvc">The user service injection.</param>
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class UserController(IConfiguration configuration, IUserService userSvc)
        : ControllerBase
    {
        private readonly IConfiguration configuration = configuration;
        private readonly IUserService userSvc = userSvc;

        /// <summary>
        /// This method will enable for the user to login into the system.
        /// </summary>
        /// <param name="request">The login request.</param>
        /// <returns>A type of <see cref="ActionResult"/>.</returns>
        [HttpPost("Login")]
        public ActionResult LoginAsync(LoginRequest request)
        {
            LoginResponse apiResponse;

            if (request.Email == "test@test.com" && request.Password == "testPassword")
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["Jwt:Key"] !));

                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Email, request.Email),
                        new Claim(ClaimTypes.GivenName, "Test User"),
                        new Claim(ClaimTypes.Role, "Admin"),
                    }),
                    Expires = DateTime.UtcNow.AddSeconds(3600),
                    NotBefore = null,
                    Audience = this.configuration["Jwt:Issuer"] !,
                    Issuer = this.configuration["Jwt:Issuer"] !,
                    SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256),
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescription);

                var result = tokenHandler.WriteToken(token);

                apiResponse = new LoginResponse
                {
                    Email = request.Email,
                    StatusCode = 200,
                    Success = true,
                    Token = result,
                };
            }
            else
            {
                apiResponse = new LoginResponse
                {
                    Token = null,
                    Success = false,
                    StatusCode = 500,
                    Email = request.Email,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
