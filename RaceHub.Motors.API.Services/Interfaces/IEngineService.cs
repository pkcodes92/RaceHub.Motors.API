// <copyright file="IEngineService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;

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
    }
}
