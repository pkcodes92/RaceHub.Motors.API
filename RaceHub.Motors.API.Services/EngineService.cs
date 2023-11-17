// <copyright file="EngineService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class will implement all of the methods that are defined in <see cref="IEngineService"/>.
    /// </summary>
    public class EngineService : IEngineService
    {
        private readonly IEngineRepository engineRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="EngineService"/> class.
        /// </summary>
        /// <param name="engineRepo">The engine repository injection.</param>
        public EngineService(IEngineRepository engineRepo)
        {
            this.engineRepo = engineRepo;
        }

        /// <summary>
        /// This method will get all the engines from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="DTO.Models.Engine"/>.</returns>
        public async Task<List<DTO.Models.Engine>> GetAllEnginesAsync()
        {
            var dbResults = await this.engineRepo.GetAllEnginesAsync();
            var results = new List<DTO.Models.Engine>();

            foreach (var item in dbResults)
            {
                var itemToAdd = new DTO.Models.Engine
                {
                    Id = item.Id,
                    Code = item.Code,
                    Description = item.Description,
                };

                results.Add(itemToAdd);
            }

            return results!;
        }

        /// <summary>
        /// This method will return a single engine from the database.
        /// </summary>
        /// <param name="id">The primary key of the Engine entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="DTO.Models.Engine"/>.</returns>
        public async Task<DTO.Models.Engine> GetEngineByIdAsync(int id)
        {
            var dbResult = await this.engineRepo.GetEngineByIdAsync(id);
            return new DTO.Models.Engine
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method will add a new engine to the database.
        /// </summary>
        /// <param name="request">The new engine being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="DTO.Models.Engine"/>.</returns>
        public async Task<DTO.Models.Engine> AddEngineAsync(AddEngineRequest request)
        {
            var engineEntityToAdd = new DAL.Entity.Engine
            {
                Code = request.Code,
                Description = request.Description,
                Created = DateTime.Now,
                CreatedBy = "RaceHub-Motors-API",
                LastUpd = DateTime.Now,
                LastUpdBy = "RaceHub-Motors-API",
                LastUpdApp = "RaceHub-Motors-API",
            };

            var dbResult = await this.engineRepo.AddEngineAsync(engineEntityToAdd);

            return new DTO.Models.Engine
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method will update an existing engine.
        /// </summary>
        /// <param name="request">The engine information to be updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="DTO.Models.Engine"/>.</returns>
        public async Task<DTO.Models.Engine> UpdateEngineAsync(UpdateEngineRequest request)
        {
            var engineToUpdate = new DAL.Entity.Engine
            {
                Code = request.Code,
                Description = request.Description,
                LastUpd = DateTime.Now,
                LastUpdBy = "RaceHub-Motors-API",
                LastUpdApp = "RaceHub-Motors-API",
                Id = request.Id,
            };

            var dbResult = await this.engineRepo.UpdateEngineAsync(engineToUpdate);

            return new DTO.Models.Engine
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method will remove an engine from the database.
        /// </summary>
        /// <param name="id">The primary key of the engine entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        public async Task<bool> DeleteEngineAsync(int id)
        {
            var result = await this.engineRepo.DeleteEngineAsync(id);
            return result;
        }
    }
}