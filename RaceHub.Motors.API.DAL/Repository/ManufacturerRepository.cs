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

        /// <summary>
        /// This method will get a single manufacturer by the primary key.
        /// </summary>
        /// <param name="id">The primary key of the manufacturer entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        public async Task<Manufacturer> GetManufacturerByIdAsync(int id)
        {
            var result = await this.context.Manufacturers.FirstOrDefaultAsync(g => g.Id == id);
            return result!;
        }

        /// <summary>
        /// This method will add a new manufacturer to the database.
        /// </summary>
        /// <param name="manufacturer">The new manufacturer being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        public async Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer)
        {
            this.context.Manufacturers.Add(manufacturer);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? manufacturer : null!;
        }

        /// <summary>
        /// This method updates an existing manufacturer in the database.
        /// </summary>
        /// <param name="manufacturer">The manufacturer information being updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        public async Task<Manufacturer> UpdateManufacturerAsync(Manufacturer manufacturer)
        {
            this.context.ChangeTracker.Clear();
            this.context.Manufacturers.Update(manufacturer);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? manufacturer : null!;
        }

        /// <summary>
        /// This method will remove a manufacturer from the database.
        /// </summary>
        /// <param name="id">The primary key of the database entity.</param>
        /// <returns>A unit of execution that contains a boolean value representing successful deletion.</returns>
        public async Task<bool> RemoveManufacturerAsync(int id)
        {
            var manufacturerToRemove = await this.context.Manufacturers.FirstOrDefaultAsync(g => g.Id == id);
            this.context.Manufacturers.Remove(manufacturerToRemove!);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }
    }
}
