// <copyright file="VehicleColorController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This controller will have methods that interact with the Vehicle Color entity.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="VehicleColorController"/> class.
    /// </remarks>
    /// <param name="vehicleColorSvc">The vehicle color service injection.</param>
    /// <param name="logger">The logging mechanism injection.</param>
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleColorController(IVehicleColorService vehicleColorSvc, ILogger<VehicleColorController> logger)
        : ControllerBase
    {
        private readonly IVehicleColorService vehicleColorSvc = vehicleColorSvc;
        private readonly ILogger<VehicleColorController> logger = logger;

        /// <summary>
        /// This method will get all of the vehicle colors from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllVehicleColors")]
        public async Task<ActionResult> GetAllVehicleColorsAsync()
        {
            this.logger.LogInformation("Getting all of the vehicle colors from the database");
            GetVehicleColorsResponse apiResponse;

            try
            {
                var results = await this.vehicleColorSvc.GetAllVehicleColorsAsync();

                apiResponse = new GetVehicleColorsResponse
                {
                    VehicleColors = results,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while getting all the vehicle colors");
                apiResponse = new GetVehicleColorsResponse
                {
                    VehicleColors = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get a single vehicle color by the ID.
        /// </summary>
        /// <param name="id">The primary key of the vehicle color entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetVehicleColorById")]
        public async Task<ActionResult> GetVehicleColorByIdAsync(int id)
        {
            this.logger.LogError("Retrieving the single vehicle color with the ID: {id}", id);
            GetVehicleColorResponse apiResponse;

            try
            {
                var result = await this.vehicleColorSvc.GetVehicleColorByIdAsync(id);

                apiResponse = new GetVehicleColorResponse
                {
                    StatusCode = 200,
                    Success = true,
                    VehicleColor = result,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error getting the vehicle color with the ID: {id}", id);
                apiResponse = new GetVehicleColorResponse
                {
                    StatusCode = 500,
                    Success = false,
                    VehicleColor = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will add a new vehicle color to the database.
        /// </summary>
        /// <param name="request">The new vehicle color being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPost("AddVehicleColor")]
        public async Task<ActionResult> AddVehicleColorAsync(AddVehicleColorRequest request)
        {
            this.logger.LogInformation("Adding a new vehicle color with the code: {code}", request.Code);
            AddVehicleColorResponse apiResponse;

            try
            {
                var result = await this.vehicleColorSvc.AddVehicleColorAsync(request);

                apiResponse = new AddVehicleColorResponse
                {
                    StatusCode = 200,
                    Success = true,
                    VehicleColor = result,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred when adding the new vehicle color with the code: {code}", request.Code);
                apiResponse = new AddVehicleColorResponse
                {
                    StatusCode = 500,
                    Success = false,
                    VehicleColor = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will update an existing vehicle color in the database.
        /// </summary>
        /// <param name="request">The update vehicle color information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPut("UpdateVehicleColor")]
        public async Task<ActionResult> UpdateVehicleColorAsync(UpdateVehicleColorRequest request)
        {
            this.logger.LogInformation("Updating the vehicle color with ID: {id}, and Code: {code}", request.Id, request.Code);
            UpdateVehicleColorResponse apiResponse;

            try
            {
                var result = await this.vehicleColorSvc.UpdateVehicleColorAsync(request);

                apiResponse = new UpdateVehicleColorResponse
                {
                    StatusCode = 200,
                    Success = true,
                    VehicleColor = result,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while updating the vehicle color with ID: {id}, and Code: {code}", request.Id, request.Code);
                apiResponse = new UpdateVehicleColorResponse
                {
                    StatusCode = 500,
                    Success = false,
                    VehicleColor = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will remove a vehicle color from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle color entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpDelete("RemoveVehicleColor")]
        public async Task<ActionResult> RemoveVehicleColorAsync(int id)
        {
            this.logger.LogInformation("Removing the vehicle color with the ID: {id}", id);
            DeleteVehicleColorResponse apiResponse;

            try
            {
                var result = await this.vehicleColorSvc.DeleteVehicleColorAsync(id);

                if (result)
                {
                    apiResponse = new DeleteVehicleColorResponse
                    {
                        StatusCode = 204,
                        Success = true,
                        Id = id,
                    };
                }
                else
                {
                    apiResponse = new DeleteVehicleColorResponse
                    {
                        StatusCode = 503,
                        Success = false,
                        Id = id,
                    };
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred when removing the vehicle color with the ID: {id}", id);
                apiResponse = new DeleteVehicleColorResponse
                {
                    StatusCode = 500,
                    Success = false,
                    Id = id,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
