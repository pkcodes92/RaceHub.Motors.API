// <copyright file="IEngineService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

    /// <summary>
    /// This interface defines all of the methods that interact with the Engine UI entity.
    /// </summary>
    public interface IEngineService
    {
        /// <summary>
        /// This method definition will get all the engines from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of <see cref="Engine"/>.</returns>
        Task<List<Engine>> GetAllEnginesAsync();

        /// <summary>
        /// This method definition will get a single engine by the primary key.
        /// </summary>
        /// <param name="id">The primary key of the engine UI entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        Task<Engine> GetEngineByIdAsync(int id);

        /// <summary>
        /// This method definition will add a new engine to the database.
        /// </summary>
        /// <param name="request">The new engine information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        Task<Engine> AddEngineAsync(AddEngineRequest request);

        /// <summary>
        /// This method definition will update an existing engine in the database.
        /// </summary>
        /// <param name="request">The information to be updated of the existing engine.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
        Task<Engine> UpdateEngineAsync(UpdateEngineRequest request);

        /// <summary>
        /// This method definition will remove an engine from the database.
        /// </summary>
        /// <param name="id">The primary key of the engine entity.</param>
        /// <returns>A boolean value indicating whether the deletion has been successful.</returns>
        Task<bool> DeleteEngineAsync(int id);
    }
}
