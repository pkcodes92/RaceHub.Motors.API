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

        /// <summary>
        /// This method will add a new vehicle type to the database.
        /// </summary>
        /// <param name="vehicleType">The vehicle type information to add.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> AddVehicleTypeAsync(VehicleType vehicleType);

        /// <summary>
        /// This method will get a single vehicle type by the primary key.
        /// </summary>
        /// <param name="id">The primary key of the vehicle entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> GetVehicleTypeAsync(int id);

        /// <summary>
        /// This method will get a single vehicle type by the code.
        /// </summary>
        /// <param name="code">The code by which to search the vehicle types.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> GetVehicleTypeAsync(string code);

        /// <summary>
        /// This method will update a vehicle type in the database.
        /// </summary>
        /// <param name="vehicleType">The updated vehicle type information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> UpdateVehicleTypeAsync(VehicleType vehicleType);

        /// <summary>
        /// This method will remove a vehicle type from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type.</param>
        /// <returns>A unit of execution that contains a value indicating successful deletion.</returns>
        Task<bool> DeleteVehicleTypeAsync(int id);
    }
}
