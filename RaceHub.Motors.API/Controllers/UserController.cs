﻿// <copyright file="UserController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using Azure.Core;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.IdentityModel.Tokens;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class represents the necessary methods to log a user into the system.
    /// </summary>
    /// <param name="configuration">The configuration settings.</param>
    /// <param name="userSvc">The user service injection.</param>
    /// <param name="logger">The logging mechanism injection.</param>
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class UserController(IConfiguration configuration, IUserService userSvc, ILogger<UserController> logger)
        : ControllerBase
    {
        private readonly IConfiguration configuration = configuration;
        private readonly IUserService userSvc = userSvc;
        private readonly ILogger<UserController> logger = logger;

        /// <summary>
        /// This method will enable for the user to login into the system.
        /// </summary>
        /// <param name="request">The login request.</param>
        /// <returns>A type of <see cref="ActionResult"/>.</returns>
        [HttpPost("Login")]
        public async Task<ActionResult> LoginAsync(LoginRequest request)
        {
            LoginResponse apiResponse;
            var user = await this.userSvc.GetUserByEmailAndPasswordAsync(request.Email, request.Password);

            if (request.Email == user.Email && request.Password == user.Password)
            {
                var result = this.GenerateToken(user);

                apiResponse = new LoginResponse
                {
                    Email = request.Email,
                    StatusCode = 200,
                    Success = true,
                    Token = result,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserType = user.Type,
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
                    FirstName = null,
                    LastName = null,
                    UserType = null,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get all of the users from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllUsers")]
        public async Task<ActionResult> GetAllUsersAsync()
        {
            this.logger.LogInformation("Getting all of the users");
            GetUsersResponse apiResponse;

            try
            {
                var results = await this.userSvc.GetAllUsersAsync();

                apiResponse = new GetUsersResponse
                {
                    Users = results,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error getting all the users from the database");

                apiResponse = new GetUsersResponse
                {
                    Users = null!,
                    StatusCode = 503,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will add a new user to the database accordingly.
        /// </summary>
        /// <param name="request">The new user being added accordingly.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPost("Register")]
        public async Task<ActionResult> RegisterAsync(AddUserRequest request)
        {
            this.logger.LogInformation("Registering the new user: {email}", request.Email);
            AddUserResponse apiResponse;

            try
            {
                var result = await this.userSvc.AddUserAsync(request);

                apiResponse = new AddUserResponse
                {
                    User = result,
                    StatusCode = 201,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred when adding the user with the email: {email}", request.Email);

                apiResponse = new AddUserResponse
                {
                    StatusCode = 500,
                    Success = false,
                    User = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        private string GenerateToken(User user)
        {
            var jwtKey = this.configuration["Jwt:Key"];
            var audience = this.configuration["Jwt:Issuer"];
            var issuer = this.configuration["Jwt:Issuer"];

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey!));

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.GivenName, $"{user.FirstName} {user.LastName}"),
                    new Claim(ClaimTypes.Role, user.Type),
                }),
                Expires = DateTime.UtcNow.AddSeconds(3600),
                NotBefore = null,
                Audience = audience!,
                Issuer = issuer!,
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256),
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescription);

            var result = tokenHandler.WriteToken(token);
            return result;
        }
    }
}
