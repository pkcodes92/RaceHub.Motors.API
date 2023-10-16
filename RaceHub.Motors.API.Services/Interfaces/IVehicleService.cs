// <copyright file="IVehicleService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This interface defines methods that interact with the Vehicle UI entity.
    /// </summary>
    public interface IVehicleService
    {
        /// <summary>
        /// This methodl will get all the vehicles from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Vehicle"/>.</returns>
        Task<List<Vehicle>> GetAllVehiclesAsync();
    }
}
