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
    }
}
