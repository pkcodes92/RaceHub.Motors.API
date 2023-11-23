// <copyright file="IVehicleColorService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

    /// <summary>
    /// This interface defines methods that interact with the Vehicle Color UI entity.
    /// </summary>
    public interface IVehicleColorService
    {
        /// <summary>
        /// This method definition gets all of the vehicle colors.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
        Task<List<VehicleColor>> GetAllVehicleColorsAsync();

        /// <summary>
        /// This method definition retrieves a single vehicle color.
        /// </summary>
        /// <param name="id">The primary key of the vehicle color entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        Task<VehicleColor> GetVehicleColorByIdAsync(int id);

        /// <summary>
        /// This method definition adds a new vehicle color to the database.
        /// </summary>
        /// <param name="request">The new vehicle color being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        Task<VehicleColor> AddVehicleColorAsync(AddVehicleColorRequest request);
    }
}
