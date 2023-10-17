// <copyright file="VehicleTypeController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the necessary methods that interact with the Vehicle Type UI entity.
    /// </summary>
    [Route("api/VehicleType")]
    [ApiController]
    public class VehicleTypeController : ControllerBase
    {
        private readonly IVehicleTypeService vehicleTypeSvc;
        private readonly ILogger<VehicleTypeController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTypeController"/> class.
        /// </summary>
        /// <param name="vehicleTypeSvc">The vehicle type service injection.</param>
        /// <param name="logger">The logging mechanism injection.</param>
        public VehicleTypeController(IVehicleTypeService vehicleTypeSvc, ILogger<VehicleTypeController> logger)
        {
            this.vehicleTypeSvc = vehicleTypeSvc;
            this.logger = logger;
        }

        [HttpGet("GetAllVehicleTypes")]
        public async Task<ActionResult> GetAllVehicleTypesAsync()
        {
            this.logger.LogInformation("Getting all vehicle types");
            GetVehicleTypesResponse apiResponse;

            try
            {
                var results = await this.vehicleTypeSvc.GetAllVehicleTypesAsync();
                apiResponse = new GetVehicleTypesResponse
                {
                    StatusCode = 200,
                    VehicleTypes = results,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error getting vehicle types");
                apiResponse = new GetVehicleTypesResponse
                {
                    VehicleTypes = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
