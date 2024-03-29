﻿// <copyright file="ManufacturerController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements methods that interact with the Manufacturer entity.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ManufacturerController"/> class.
    /// </remarks>
    /// <param name="manufacturerSvc">The manufacturer service injection.</param>
    /// <param name="logger">The logging mechanism injection.</param>
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class ManufacturerController(IManufacturerService manufacturerSvc, ILogger<ManufacturerController> logger)
        : ControllerBase
    {
        private readonly IManufacturerService manufacturerSvc = manufacturerSvc;
        private readonly ILogger<ManufacturerController> logger = logger;

        /// <summary>
        /// This method gets all the manufacturers from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllManufacturers")]
        public async Task<ActionResult> GetAllManufacturersAsync()
        {
            this.logger.LogInformation("Getting all the manufacturers");
            GetManufacturersResponse apiResponse;

            try
            {
                var results = await this.manufacturerSvc.GetAllManufacturersAsync();
                apiResponse = new GetManufacturersResponse
                {
                    Manufacturers = results,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error getting the manufacturers from the database");
                apiResponse = new GetManufacturersResponse
                {
                    Manufacturers = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get all of the manufacturers that belong to a country.
        /// </summary>
        /// <param name="countryCode">The country code to search for manufacturers.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetManufacturersByCountryCode")]
        public async Task<ActionResult> GetAllManufacturersByCountryCode(string countryCode)
        {
            this.logger.LogInformation("Getting all of the manufacturers in the country: {countryCode}", countryCode);
            GetManufacturersResponse apiResponse;

            try
            {
                var results = await this.manufacturerSvc.GetManufacturersByCountryCodeAsync(countryCode);
                apiResponse = new GetManufacturersResponse
                {
                    Manufacturers = results,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error getting the manufacturers in the country: {countryCode}", countryCode);
                apiResponse = new GetManufacturersResponse
                {
                    Manufacturers = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get all the manufacturer countries.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllManufacturerCountries")]
        public async Task<ActionResult> GetAllManufacturerCountriesAsync()
        {
            this.logger.LogInformation("Getting all the countries");
            GetCountriesResponse apiResponse;

            try
            {
                var results = await this.manufacturerSvc.GetAllManufacturerCountriesAsync();
                apiResponse = new GetCountriesResponse
                {
                    Countries = results,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while trying to get the countries");
                apiResponse = new GetCountriesResponse
                {
                    Countries = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will get a single country by the country code.
        /// </summary>
        /// <param name="countryCode">The single country code.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetCountryByCode")]
        public async Task<ActionResult> GetCountryByCode(string countryCode)
        {
            this.logger.LogInformation("Getting the country information for: {countryCode}", countryCode);
            GetCountryResponse apiResponse;

            try
            {
                var result = await this.manufacturerSvc.GetCountryByCodeAsync(countryCode);
                apiResponse = new GetCountryResponse
                {
                    Country = result,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while trying to get the country by the code: {countryCode}", countryCode);
                apiResponse = new GetCountryResponse
                {
                    Country = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will add a new manufacturer to the database.
        /// </summary>
        /// <param name="request">The new manufacturer being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPost("AddManufacturer")]
        public async Task<ActionResult> AddManufacturerAsync(AddManufacturerRequest request)
        {
            this.logger.LogInformation("Adding the new manufacturer named: {name}", request.Name);
            AddManufacturerResponse apiResponse;

            try
            {
                var result = await this.manufacturerSvc.AddManufacturerAsync(request);

                apiResponse = new AddManufacturerResponse
                {
                    Manufacturer = result,
                    StatusCode = 201,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while adding the manufacturer: {name}", request.Name);
                apiResponse = new AddManufacturerResponse
                {
                    Manufacturer = null,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will update an existing manufacturer in the database.
        /// </summary>
        /// <param name="request">The updated manufacturer request information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPut("UpdateManufacturer")]
        public async Task<ActionResult> UpdateManufacturerAsync(UpdateManufacturerRequest request)
        {
            this.logger.LogInformation("Updating the manufacturer with the name: {name}", request.Name);
            UpdateManufacturerResponse apiResponse;

            try
            {
                var result = await this.manufacturerSvc.UpdateManufacturerAsync(request);

                apiResponse = new UpdateManufacturerResponse
                {
                    Manufacturer = result,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while updating the manufacturer with the name: {name}", request.Name);

                apiResponse = new UpdateManufacturerResponse
                {
                    Manufacturer = null,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will remove a manufacturer from the database.
        /// </summary>
        /// <param name="id">The primary key of the manufacturer entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpDelete("RemoveManufacturer")]
        public async Task<ActionResult> RemoveManufacturerAsync(int id)
        {
            this.logger.LogInformation("Removing the manufacturer with ID: {id}", id);
            DeleteManufacturerResponse apiResponse;

            try
            {
                var result = await this.manufacturerSvc.RemoveManufacturerAsync(id);

                if (result)
                {
                    apiResponse = new DeleteManufacturerResponse
                    {
                        Id = id,
                        Success = true,
                        StatusCode = 204,
                    };
                }
                else
                {
                    apiResponse = new DeleteManufacturerResponse
                    {
                        Id = id,
                        StatusCode = 503,
                        Success = false,
                    };
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred while removing the manufacturer with ID: {id}", id);

                apiResponse = new DeleteManufacturerResponse
                {
                    Id = id,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
