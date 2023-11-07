// <copyright file="DrivetrainController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class contains methods that interact witht the Drivetrain UI entity.
    /// </summary>
    [ApiController]
    [Route("api/Drivetrain")]
    public class DrivetrainController : ControllerBase
    {
        private readonly ILogger<DrivetrainController> logger;
        private readonly IDrivetrainService drivetrainSvc;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrivetrainController"/> class.
        /// </summary>
        /// <param name="logger">The logging mechanism injection.</param>
        /// <param name="drivetrainSvc">The drivetrain service injection.</param>
        public DrivetrainController(ILogger<DrivetrainController> logger, IDrivetrainService drivetrainSvc)
        {
            this.logger = logger;
            this.drivetrainSvc = drivetrainSvc;
        }

        /// <summary>
        /// This method will get all the drivetrains from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllDrivetrains")]
        public async Task<ActionResult> GetAllDrivetrainsAsync()
        {
            this.logger.LogInformation("Getting all drivetrains");
            GetDrivetrainsResponse apiResponse;

            try
            {
                var results = await this.drivetrainSvc.GetAllDrivetrainsAsync();
                apiResponse = new GetDrivetrainsResponse
                {
                    Drivetrains = results!,
                    Success = true,
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while getting the drivetrains!");
                apiResponse = new GetDrivetrainsResponse
                {
                    Drivetrains = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get a single Drivetrain searching the primary key.
        /// </summary>
        /// <param name="id">The primary key of the Drivetrain UI entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetDrivetrainById")]
        public async Task<ActionResult> GetDrivetrainByIdAsync(int id)
        {
            this.logger.LogInformation("Getting the drivetrain with the primary key: {id}", id);
            GetDrivetrainResponse apiResponse;

            try
            {
                var result = await this.drivetrainSvc.GetDrivetrainByIdAsync(id);
                apiResponse = new GetDrivetrainResponse
                {
                    Drivetrain = result,
                    Success = true,
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error when getting the drivetrain with the primary key: {id}", id);
                apiResponse = new GetDrivetrainResponse
                {
                    Drivetrain = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will add a new drivetrain to the database.
        /// </summary>
        /// <param name="request">The new drivetrain information to be added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPost("AddDrivetrain")]
        public async Task<ActionResult> AddDrivetrainAsync(AddDrivetrainRequest request)
        {
            this.logger.LogInformation("Adding the new drivetrain with code: {code}", request.Code);
            AddDrivetrainResponse apiResponse;

            try
            {
                var result = await this.drivetrainSvc.AddDrivetrainAsync(request);

                apiResponse = new AddDrivetrainResponse
                {
                    Drivetrain = result,
                    Success = true,
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while adding the drivetrain with the code: {code}", request.Code);
                apiResponse = new AddDrivetrainResponse
                {
                    Drivetrain = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will update an existing drivetrain in the database.
        /// </summary>
        /// <param name="request">The drivetrain information being updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPut("UpdateDrivetrain")]
        public async Task<ActionResult> UpdateDrivetrainAsync(UpdateDrivetrainRequest request)
        {
            this.logger.LogInformation("Updating the drivetrain with the code: {code}", request.Code);
            UpdateDrivetrainResponse apiResponse;

            try
            {
                var result = await this.drivetrainSvc.UpdateDrivetrainAsync(request);

                apiResponse = new UpdateDrivetrainResponse
                {
                    Drivetrain = result,
                    Success = true,
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while updating the drivetrain with the code: {code}", request.Code);
                apiResponse = new UpdateDrivetrainResponse
                {
                    Drivetrain = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
