// <copyright file="EngineService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
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
        /// <returns>A unit of execution that contains a list of type <see cref="Engine"/>.</returns>
        public async Task<List<Engine>> GetAllEnginesAsync()
        {
            var dbResults = await this.engineRepo.GetAllEnginesAsync();
            var results = new List<Engine>();

            foreach (var item in dbResults)
            {
                var itemToAdd = new Engine
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
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        public async Task<Engine> GetEngineByIdAsync(int id)
        {
            var dbResult = await this.engineRepo.GetEngineByIdAsync(id);
            return new Engine
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }
    }
}