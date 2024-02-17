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
    }
}
