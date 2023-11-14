// <copyright file="ManufacturerController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DTO;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements methods that interact with the Manufacturer entity.
    /// </summary>
    [ApiController]
    [Route("api/Manufacturer")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService manufacturerSvc;
        private readonly ILogger<ManufacturerController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManufacturerController"/> class.
        /// </summary>
        /// <param name="manufacturerSvc">The manufacturer service injection.</param>
        /// <param name="logger">The logging mechanism injection.</param>
        public ManufacturerController(IManufacturerService manufacturerSvc, ILogger<ManufacturerController> logger)
        {
            this.manufacturerSvc = manufacturerSvc;
            this.logger = logger;
        }

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
                var originalResults = await this.manufacturerSvc.GetAllManufacturersAsync();
                var distinctResults = originalResults.DistinctBy(g => g.Country).ToList();

                var results = new List<Country>();

                foreach (var country in distinctResults)
                {
                    var itemToAdd = new Country
                    {
                        CountryCode = country.CountryCode,
                        Flag = country.Flag,
                        Name = country.Country,
                        Region = country.Region,
                    };

                    results.Add(itemToAdd);
                }

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
                    StatusCode = 200,
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
    }
}
