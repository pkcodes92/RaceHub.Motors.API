// <copyright file="IVehicleTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

    /// <summary>
    /// This interface defines the methods for interacting with the Vehicle Type UI entity.
    /// </summary>
    public interface IVehicleTypeService
    {
        /// <summary>
        /// This method definition will get all the vehicle types.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="VehicleType"/>.</returns>
        Task<List<VehicleType>> GetAllVehicleTypesAsync();

        /// <summary>
        /// This method will get a single vehicle type.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains the type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> GetVehicleTypeAsync(int id);

        /// <summary>
        /// This method will get a single vehicle type.
        /// </summary>
        /// <param name="code">The code by which to search.</param>
        /// <returns>A unit of execution that contains the type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> GetVehicleTypeAsync(string code);

        /// <summary>
        /// This method definition will add a new vehicle type.
        /// </summary>
        /// <param name="request">The new vehicle type information to be added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> AddVehicleTypeAsync(AddVehicleTypeRequest request);

        /// <summary>
        /// This method definition will update an existing vehicle type in the database.
        /// </summary>
        /// <param name="request">The vehicle type information to be updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        Task<VehicleType> UpdateVehicleTypeAsync(UpdateVehicleTypeRequest request);

        /// <summary>
        /// This method definition removes the vehicle type from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains a boolean value to indicate successful deletion.</returns>
        Task<bool> DeleteVehicleTypeAsync(int id);
    }
}
