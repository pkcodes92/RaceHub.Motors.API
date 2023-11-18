// <copyright file="VehicleColorController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This controller will have methods that interact with the Vehicle Color entity.
    /// </summary>
    [ApiController]
    [Route("api/VehicleColor")]
    public class VehicleColorController : ControllerBase
    {
        private readonly IVehicleColorService vehicleColorSvc;
        private readonly ILogger<VehicleColorController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleColorController"/> class.
        /// </summary>
        /// <param name="vehicleColorSvc">The vehicle color service injection.</param>
        /// <param name="logger">The logging mechanism injection.</param>
        public VehicleColorController(IVehicleColorService vehicleColorSvc, ILogger<VehicleColorController> logger)
        {
            this.vehicleColorSvc = vehicleColorSvc;
            this.logger = logger;
        }

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
    }
}
