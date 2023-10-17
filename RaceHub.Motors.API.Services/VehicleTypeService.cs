// <copyright file="VehicleTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements methods defined in <see cref="IVehicleTypeService"/>.
    /// </summary>
    public class VehicleTypeService : IVehicleTypeService
    {
        private readonly IVehicleTypeRepository vehicleTypeRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTypeService"/> class.
        /// </summary>
        /// <param name="vehicleTypeRepo">The vehicle type repository injection.</param>
        public VehicleTypeService(IVehicleTypeRepository vehicleTypeRepo)
        {
            this.vehicleTypeRepo = vehicleTypeRepo;
        }

        public async Task<List<VehicleType>> GetAllVehicleTypesAsync()
        {
            var dbResults = await this.vehicleTypeRepo.GetAllVehicleTypesAsync();
            var results = new List<VehicleType>();

            foreach (var dbResult in dbResults)
            {
                var itemToAdd = new VehicleType
                {
                    Id = dbResult.Id,
                    Code = dbResult.TypeCode,
                    Description = dbResult.Description,
                };

                results.Add(itemToAdd);
            }

            return results!;
        }
    }
}
