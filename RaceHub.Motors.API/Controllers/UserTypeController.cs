// <copyright file="UserTypeController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the basic CRUD methods with the User Type UI entity.
    /// </summary>
    /// <param name="userTypeSvc">The user type service injection.</param>
    /// <param name="logger">The logging mechanism injection.</param>
    [ApiController]
    [Route("api/[controller]")]
    public class UserTypeController(IUserTypeService userTypeSvc, ILogger<UserTypeController> logger)
        : ControllerBase
    {
        private readonly IUserTypeService userTypeSvc = userTypeSvc;
        private readonly ILogger<UserTypeController> logger = logger;

        /// <summary>
        /// This API method will add a new user type into the database.
        /// </summary>
        /// <param name="request">The new user type being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPost("AddUserType")]
        public async Task<ActionResult> AddUserTypeAsync(AddUserTypeRequest request)
        {
            this.logger.LogInformation("Adding a new user type: {description}", request.Description);
            AddUserTypeResponse apiResponse;

            try
            {
                var result = await this.userTypeSvc.AddUserTypeAsync(request);

                apiResponse = new AddUserTypeResponse
                {
                    StatusCode = 201,
                    UserType = result,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while trying to add the user type: {description}", request.Description);

                apiResponse = new AddUserTypeResponse
                {
                    Success = false,
                    UserType = null!,
                    StatusCode = 500,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get a single user type from the database.
        /// </summary>
        /// <param name="id">The primary key of the user type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetUserType")]
        public async Task<ActionResult> GetUserTypeByIdAsync(int id)
        {
            this.logger.LogInformation("Getting the user type with the ID: {id}", id);
            GetUserTypeResponse apiResponse;

            try
            {
                var result = await this.userTypeSvc.GetUserTypeByIdAsync(id);

                apiResponse = new GetUserTypeResponse
                {
                    Success = true,
                    UserType = result,
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while trying to get the user type with ID: {id}", id);

                apiResponse = new GetUserTypeResponse
                {
                    UserType = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get a single user type from the database.
        /// </summary>
        /// <param name="description">The description of the user type to search for.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetUserTypeByDesc")]
        public async Task<ActionResult> GetUserTypeByDescAsync(string description)
        {
            this.logger.LogInformation("Getting the user type with the description: {description}", description);
            GetUserTypeResponse apiResponse;

            try
            {
                var result = await this.userTypeSvc.GetUserTypeByDescription(description);

                apiResponse = new GetUserTypeResponse
                {
                    Success = true,
                    UserType = result,
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while trying to get the user type with the description: {description}", description);

                apiResponse = new GetUserTypeResponse
                {
                    StatusCode = 500,
                    Success = false,
                    UserType = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        [HttpGet("GetAllUserTypes")]
        public async Task<ActionResult> GetAllUserTypesAsync()
        {
            this.logger.LogInformation("Getting all the user types");
            GetUserTypesResponse apiResponse;

            try
            {
                var results = await this.userTypeSvc.GetUserTypesAsync();

                apiResponse = new GetUserTypesResponse
                {
                    Success = true,
                    StatusCode = 200,
                    UserTypes = results,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while getting the user types.");

                apiResponse = new GetUserTypesResponse
                {
                    UserTypes = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
