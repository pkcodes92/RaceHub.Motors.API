// <copyright file="IVehicleColorRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This interface defines the methods that interact with the Vehicle Color entity.
    /// </summary>
    public interface IVehicleColorRepository
    {
        /// <summary>
        /// This method definition gets all of the vehicle colors in the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
        Task<List<VehicleColor>> GetVehicleColorsAsync();

        /// <summary>
        /// This method definition gets a single vehicle color by the primary key.
        /// </summary>
        /// <param name="id">The primary key of the <see cref="VehicleColor"/> entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        Task<VehicleColor> GetVehicleColorByIdAsync(int id);
    }
}
