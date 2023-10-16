// <copyright file="EngineRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class implements the methods that are defined in <see cref="IEngineRepository"/>.
    /// </summary>
    public class EngineRepository : IEngineRepository
    {
        private readonly RaceHubMotorsContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="EngineRepository"/> class.
        /// </summary>
        /// <param name="context">The database context injection.</param>
        public EngineRepository(RaceHubMotorsContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// This method will return all of the engines that are in the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Engine"/>.</returns>
        public async Task<List<Engine>> GetAllEnginesAsync()
        {
            var results = await this.context.Engines.ToListAsync();
            return results!;
        }

        /// <summary>
        /// This method will return a single engine by searching the primary key.
        /// </summary>
        /// <param name="id">The primary key of the Engine entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        public async Task<Engine> GetEngineByIdAsync(int id)
        {
            var result = await this.context.Engines.FirstOrDefaultAsync(g => g.Id == id);
            return result!;
        }
    }
}
