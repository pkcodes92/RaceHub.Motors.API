// <copyright file="ManufacturerRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class implements methods defined in <see cref="IManufacturerRepository"/>.
    /// </summary>
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly RaceHubMotorsContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManufacturerRepository"/> class.
        /// </summary>
        /// <param name="context">The database context injection layer.</param>
        public ManufacturerRepository(RaceHubMotorsContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// This method will return all of the manufacturers in the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Manufacturer"/>.</returns>
        public async Task<List<Manufacturer>> GetAllManufacturersAsync()
        {
            var results = await this.context.Manufacturers.ToListAsync();
            return results!;
        }
    }
}
