// <copyright file="VehicleRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IVehicleRepository"/>.
    /// </summary>
    public class VehicleRepository : IVehicleRepository
    {
        private readonly RaceHubMotorsContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleRepository"/> class.
        /// </summary>
        /// <param name="context">The database context injection.</param>
        public VehicleRepository(RaceHubMotorsContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// This method returns all of the vehicles from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Vehicle"/>.</returns>
        public async Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            var results = await this.context.Vehicles.ToListAsync();
            return results!;
        }
    }
}
