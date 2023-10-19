// <copyright file="VehicleColorService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class will implement the methods defined in <see cref="IVehicleColorService"/>.
    /// </summary>
    public class VehicleColorService : IVehicleColorService
    {
        private readonly IVehicleColorRepository vehicleColorRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleColorService"/> class.
        /// </summary>
        /// <param name="vehicleColorRepo">The vehicle color repository injection.</param>
        public VehicleColorService(IVehicleColorRepository vehicleColorRepo)
        {
            this.vehicleColorRepo = vehicleColorRepo;
        }

        /// <summary>
        /// This method will get all of the vehicle colors from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
        public async Task<List<VehicleColor>> GetAllVehicleColorsAsync()
        {
            var dbResults = await this.vehicleColorRepo.GetVehicleColorsAsync();
            var results = new List<VehicleColor>();

            foreach (var vehicleColor in dbResults)
            {
                var itemToAdd = new VehicleColor
                {
                    Id = vehicleColor.Id,
                    Code = vehicleColor.Code,
                    Description = vehicleColor.Description,
                };

                results.Add(itemToAdd);
            }

            return results!;
        }

        /// <summary>
        /// This method will get a single vehicle color by searching the primary key.
        /// </summary>
        /// <param name="id">The primary key of the vehicle color UI entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        public async Task<VehicleColor> GetVehicleColorByIdAsync(int id)
        {
            var dbResult = await this.vehicleColorRepo.GetVehicleColorByIdAsync(id);

            return new VehicleColor
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }
    }
}
