// <copyright file="VehicleColorRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IVehicleColorRepository"/>.
    /// </summary>
    public class VehicleColorRepository : IVehicleColorRepository
    {
        private readonly RaceHubMotorsContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleColorRepository"/> class.
        /// </summary>
        /// <param name="context">The database context injection.</param>
        public VehicleColorRepository(RaceHubMotorsContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// This method will get a single vehicle color by the ID.
        /// </summary>
        /// <param name="id">The primary key of the vehicle color entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        public async Task<VehicleColor> GetVehicleColorByIdAsync(int id)
        {
            var result = await this.context.VehicleColors.FirstOrDefaultAsync(k => k.Id == id);
            return result!;
        }

        /// <summary>
        /// This method will get all the vehicle colors in the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
        public async Task<List<VehicleColor>> GetVehicleColorsAsync()
        {
            var results = await this.context.VehicleColors.ToListAsync();
            return results!;
        }

        /// <summary>
        /// This method adds a new vehicle color to the database.
        /// </summary>
        /// <param name="vehicleColor">The new vehicle color being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        public async Task<VehicleColor> AddVehicleColorAsync(VehicleColor vehicleColor)
        {
            this.context.VehicleColors.Add(vehicleColor);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? vehicleColor : null!;
        }
    }
}
