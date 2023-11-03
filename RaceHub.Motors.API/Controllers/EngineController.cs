// <copyright file="EngineController.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.DTO.Response;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This controller contains methods that will interact with the Engine UI entity.
    /// </summary>
    [ApiController]
    [Route("api/Engine")]
    public class EngineController : ControllerBase
    {
        private readonly ILogger<EngineController> logger;
        private readonly IEngineService engineSvc;

        /// <summary>
        /// Initializes a new instance of the <see cref="EngineController"/> class.
        /// </summary>
        /// <param name="logger">The logging mechanism injection.</param>
        /// <param name="engineSvc">The engine service injection.</param>
        public EngineController(ILogger<EngineController> logger, IEngineService engineSvc)
        {
            this.logger = logger;
            this.engineSvc = engineSvc;
        }

        /// <summary>
        /// This method will get all of the engines from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllEngines")]
        public async Task<ActionResult> GetAllEnginesAsync()
        {
            this.logger.LogInformation("Getting all the engines from the database.");
            GetEnginesResponse apiResponse;

            try
            {
                var results = await this.engineSvc.GetAllEnginesAsync();
                apiResponse = new GetEnginesResponse
                {
                    Engines = results,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred when getting the engines");
                apiResponse = new GetEnginesResponse
                {
                    Engines = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will retrieve a single engine by querying the primary key.
        /// </summary>
        /// <param name="id">The primary key of the engine UI entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetEngineById")]
        public async Task<ActionResult> GetEngineByIdAsync(int id)
        {
            this.logger.LogInformation("Getting the Engine information by the ID: {id}", id);
            GetEngineResponse apiResponse;

            try
            {
                var result = await this.engineSvc.GetEngineByIdAsync(id);
                apiResponse = new GetEngineResponse
                {
                    Engine = result,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error getting the engine with ID: {id}", id);
                apiResponse = new GetEngineResponse
                {
                    Engine = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }

        /// <summary>
        /// This method will add a new engine to the database.
        /// </summary>
        /// <param name="request">The new engine information that is being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpPost("AddEngine")]
        public async Task<ActionResult> AddEngineAsync(AddEngineRequest request)
        {
            this.logger.LogInformation("Adding the new engine with code: {code}", request.Code);
            AddEngineResponse apiResponse;

            try
            {
                var result = await this.engineSvc.AddEngineAsync(request);

                apiResponse = new AddEngineResponse
                {
                    Engine = result,
                    StatusCode = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error occurred when adding the new engine with the code: {code}", request.Code);
                apiResponse = new AddEngineResponse
                {
                    Engine = null!,
                    StatusCode = 500,
                    Success = false,
                };
            }

            return this.Ok(apiResponse);
        }
    }
}
