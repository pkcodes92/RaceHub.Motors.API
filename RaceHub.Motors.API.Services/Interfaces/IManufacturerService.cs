// <copyright file="IManufacturerService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

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

        /// <summary>
        /// This method definition will add a new manufacturer to the database.
        /// </summary>
        /// <param name="request">The new manufacturer information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        Task<Manufacturer> AddManufacturerAsync(AddManufacturerRequest request);

        /// <summary>
        /// This method definition will update a manufacturer in the database.
        /// </summary>
        /// <param name="request">The updated manufacturer information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        Task<Manufacturer> UpdateManufacturerAsync(UpdateManufacturerRequest request);

        /// <summary>
        /// This method definition will remove a manufacturer from the database.
        /// </summary>
        /// <param name="id">The primary key of the manufacturer entity.</param>
        /// <returns>A unit of execution that contains a boolean value which indicates successful deletion.</returns>
        Task<bool> RemoveManufacturerAsync(int id);
    }
}
