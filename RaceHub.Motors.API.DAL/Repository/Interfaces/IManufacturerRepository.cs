// <copyright file="IManufacturerRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This interface defines methods that interact with the <see cref="Manufacturer"/> entity.
    /// </summary>
    public interface IManufacturerRepository
    {
        /// <summary>
        /// This method definition gets all the manufacturers in the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Manufacturer"/>.</returns>
        Task<List<Manufacturer>> GetAllManufacturersAsync();

        /// <summary>
        /// This method definition gets the manufacturer by the ID.
        /// </summary>
        /// <param name="id">The primary key of the manufacturer DB entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        Task<Manufacturer> GetManufacturerByIdAsync(int id);

        /// <summary>
        /// This method definition adds a new manufacturer to the database.
        /// </summary>
        /// <param name="manufacturer">The new manufacturer being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer);

        /// <summary>
        /// This method definition updates a manufacturer in the database.
        /// </summary>
        /// <param name="manufacturer">The updated manufacturer information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        Task<Manufacturer> UpdateManufacturerAsync(Manufacturer manufacturer);

        /// <summary>
        /// This method definition removes a manufacturer from the database.
        /// </summary>
        /// <param name="id">The primary key of the manufacturer entity.</param>
        /// <returns>A unit of execution that contains a boolean indicating successful deletion.</returns>
        Task<bool> RemoveManufacturerAsync(int id);
    }
}
