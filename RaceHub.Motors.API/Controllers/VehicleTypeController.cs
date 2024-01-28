// <copyright file="VehicleTypeController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the necessary methods that interact with the Vehicle Type UI entity.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="VehicleTypeController"/> class.
    /// </remarks>
    /// <param name="vehicleTypeSvc">The vehicle type service injection.</param>
    /// <param name="logger">The logging mechanism injection.</param>
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypeController(IVehicleTypeService vehicleTypeSvc, ILogger<VehicleTypeController> logger)
        : ControllerBase
    {
        private readonly IVehicleTypeService vehicleTypeSvc = vehicleTypeSvc;
        private readonly ILogger<VehicleTypeController> logger = logger;

        /// <summary>
        /// This method will get all of the various vehicle types from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
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

        /// <summary>
        /// This method will get a single vehicle type from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetVehicleTypeById")]
        public async Task<ActionResult> GetVehicleTypeAsync(int id)
        {
            this.logger.LogInformation("Getting the vehicle type with the ID: {id}", id);
            GetVehicleTypeResponse apiResponse;

            try
            {
                var result = await this.vehicleTypeSvc.GetVehicleTypeAsync(id);

                apiResponse = new GetVehicleTypeResponse
                {
                    StatusCode = 200,
                    VehicleType = result,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while getting the vehicle type with the ID: {id}", id);

                apiResponse = new GetVehicleTypeResponse
                {
                    StatusCode = 500,
                    Success = false,
                    VehicleType = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get a single vehicle type from the database.
        /// </summary>
        /// <param name="code">The code to search the vehicle types.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetVehicleTypeByCode")]
        public async Task<ActionResult> GetVehicleTypeAsyc(string code)
        {
            this.logger.LogInformation("Getting the vehicle type with the code: {code}", code);
            GetVehicleTypeResponse apiResponse;

            try
            {
                var result = await this.vehicleTypeSvc.GetVehicleTypeAsync(code);

                apiResponse = new GetVehicleTypeResponse
                {
                    StatusCode = 200,
                    VehicleType = result,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error getting the vehicle type with the code: {code}", code);

                apiResponse = new GetVehicleTypeResponse
                {
                    StatusCode = 500,
                    Success = false,
                    VehicleType = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will add a new vehicle type to the database.
        /// </summary>
        /// <param name="request">The new vehicle type information to be added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPost("AddVehicleType")]
        public async Task<ActionResult> AddVehicleTypeAsync(AddVehicleTypeRequest request)
        {
            this.logger.LogInformation("Adding the vehicle type with the code: {code}", request.Code);
            AddVehicleTypeResponse apiResponse;

            try
            {
                var result = await this.vehicleTypeSvc.AddVehicleTypeAsync(request);

                apiResponse = new AddVehicleTypeResponse
                {
                    StatusCode = 201,
                    Success = true,
                    VehicleType = result,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while trying to add the vehicle type with the code: {code}", request.Code);

                apiResponse = new AddVehicleTypeResponse
                {
                    StatusCode = 500,
                    Success = false,
                    VehicleType = null!,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will update an existing vehicle type in the database.
        /// </summary>
        /// <param name="request">The existing vehicle type information to be updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPut("UpdateVehicleType")]
        public async Task<ActionResult> UpdateVehicleTypeAsync(UpdateVehicleTypeRequest request)
        {
            this.logger.LogInformation("Updating the vehicle type with the code: {code}", request.Code);
            UpdateVehicleTypeResponse apiResponse;

            try
            {
                var result = await this.vehicleTypeSvc.UpdateVehicleTypeAsync(request);

                apiResponse = new UpdateVehicleTypeResponse
                {
                    StatusCode = 200,
                    Success = true,
                    VehicleType = result,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while updating the vehicle type with the code: {code}", request.Code);

                apiResponse = new UpdateVehicleTypeResponse
                {
                    StatusCode = 500,
                    Success = true,
                    VehicleType = null!,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
