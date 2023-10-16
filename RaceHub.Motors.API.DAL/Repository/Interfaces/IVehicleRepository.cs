// <copyright file="IVehicleRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This interface will define the methods that interact with the Vehicle entity.
    /// </summary>
    public interface IVehicleRepository
    {
        /// <summary>
        /// This method gets all of the vehicles from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Vehicle"/>.</returns>
        Task<List<Vehicle>> GetAllVehiclesAsync();
    }
}
