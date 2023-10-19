// <copyright file="IVehicleTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;

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
    }
}
