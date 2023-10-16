// <copyright file="VehicleTypeRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class implements methods defined in <see cref="IVehicleTypeRepository"/>.
    /// </summary>
    public class VehicleTypeRepository : IVehicleTypeRepository
    {
        private readonly RaceHubMotorsContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTypeRepository"/> class.
        /// </summary>
        /// <param name="context">The database context injection.</param>
        public VehicleTypeRepository(RaceHubMotorsContext context)
        {
            this.context = context;
        }

        public async Task<List<VehicleType>> GetAllVehicleTypesAsync()
        {
            var results = await this.context.VehicleTypes.ToListAsync();
            return results!;
        }
    }
}
