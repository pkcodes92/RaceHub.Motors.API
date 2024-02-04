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
    /// Initializes a new instance of the <see cref="EngineRepository"/> class.
    /// </summary>
    /// <param name="context">The database context injection.</param>
    public class EngineRepository(RaceHubMotorsContext context)
        : IEngineRepository
    {
        private readonly RaceHubMotorsContext context = context;

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

        /// <summary>
        /// This method will add a new engine to the database.
        /// </summary>
        /// <param name="engine">The new engine being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        public async Task<Engine> AddEngineAsync(Engine engine)
        {
            this.context.Engines.Add(engine);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? engine : null!;
        }

        /// <summary>
        /// This method will update an engine in the database.
        /// </summary>
        /// <param name="engine">The engine information being updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        public async Task<Engine> UpdateEngineAsync(Engine engine)
        {
            this.context.ChangeTracker.Clear();
            this.context.Engines.Update(engine);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? engine : null!;
        }

        /// <summary>
        /// This method will remove an engine from the database.
        /// </summary>
        /// <param name="id">The primary key of the <see cref="Engine"/> entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        public async Task<bool> DeleteEngineAsync(int id)
        {
            var engineToDelete = await this.context.Engines.FirstOrDefaultAsync(g => g.Id == id);
            this.context.Engines.Remove(engineToDelete!);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }
    }
}
