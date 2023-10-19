// <copyright file="VehicleService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IVehicleService"/>.
    /// </summary>
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepo;
        private readonly IManufacturerRepository manufacturerRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleService"/> class.
        /// </summary>
        /// <param name="vehicleRepo">The vehicle repository injection.</param>
        /// <param name="manufacturerRepo">The manufacturer repository injection.</param>
        public VehicleService(IVehicleRepository vehicleRepo, IManufacturerRepository manufacturerRepo)
        {
            this.vehicleRepo = vehicleRepo;
            this.manufacturerRepo = manufacturerRepo;
        }

        /// <summary>
        /// This method will get all the vehicles from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type of <see cref="Vehicle"/>.</returns>
        public async Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            var dbResults = await this.vehicleRepo.GetAllVehiclesAsync();
            var results = new List<Vehicle>();

            foreach (var vehicle in dbResults)
            {
                var manufacturer = await this.manufacturerRepo.GetManufacturerByIdAsync(vehicle.ManufacturerId);

                var itemToAdd = new Vehicle
                {
                    Id = vehicle.Id,
                    Name = vehicle.Name,
                    Image = vehicle.VehImage,
                    TypeCode = vehicle.TypeCode,
                    Year = vehicle.VehYear,
                    Manufacturer = manufacturer.Name,
                };

                results.Add(itemToAdd);
            }

            return results;
        }
    }
}
