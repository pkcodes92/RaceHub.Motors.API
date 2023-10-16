// <copyright file="IManufacturerService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This interface defines the necessary methods that interact with the Manufacturer UI entity.
    /// </summary>
    public interface IManufacturerService
    {
        /// <summary>
        /// This method will get all the manufacturers from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Manufacturer"/>.</returns>
        Task<List<Manufacturer>> GetAllManufacturersAsync();
    }
}
