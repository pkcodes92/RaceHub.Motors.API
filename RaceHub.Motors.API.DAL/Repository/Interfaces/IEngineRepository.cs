// <copyright file="IEngineRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This interface defines methods that interact with the <see cref="Engine"/> DB entity.
    /// </summary>
    public interface IEngineRepository
    {
        /// <summary>
        /// This method will get all of the engines from the database.
        /// </summary>
        /// <returns>A unit of execution that returns a list of type <see cref="Engine"/>.</returns>
        Task<List<Engine>> GetAllEnginesAsync();

        /// <summary>
        /// This method definition returns a single engine by the primary key.
        /// </summary>
        /// <param name="id">The primary key of the Engine entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        Task<Engine> GetEngineByIdAsync(int id);

        /// <summary>
        /// This method definition adds a new engine to the database.
        /// </summary>
        /// <param name="engine">The new engine being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        Task<Engine> AddEngineAsync(Engine engine);

        /// <summary>
        /// This method definition updates an engine in the database.
        /// </summary>
        /// <param name="engine">The engine to be updated in the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        Task<Engine> UpdateEngineAsync(Engine engine);

        /// <summary>
        /// This method definition removes an engine from the database.
        /// </summary>
        /// <param name="id">The primary key of the <see cref="Engine"/> entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        Task<bool> DeleteEngineAsync(int id);
    }
}
