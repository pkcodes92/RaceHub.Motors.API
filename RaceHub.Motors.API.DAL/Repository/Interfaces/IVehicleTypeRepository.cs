// <copyright file="IVehicleTypeRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This class defines methods that interact with the Vehicle Type entity.
    /// </summary>
    public interface IVehicleTypeRepository
    {
        /// <summary>
        /// This method gets all of the vehicle types from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="VehicleType"/>.</returns>
        Task<List<VehicleType>> GetAllVehicleTypesAsync();
    }
}
