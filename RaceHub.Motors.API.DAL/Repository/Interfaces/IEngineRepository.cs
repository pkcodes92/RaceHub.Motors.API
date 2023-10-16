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
    }
}
