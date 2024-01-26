// <copyright file="VehicleTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// Initializes a new instance of the <see cref="VehicleTypeService"/> class.
    /// </summary>
    /// <param name="vehicleTypeRepo">The vehicle type repository injection.</param>
    public class VehicleTypeService(IVehicleTypeRepository vehicleTypeRepo)
        : IVehicleTypeService
    {
        private readonly IVehicleTypeRepository vehicleTypeRepo = vehicleTypeRepo;

        public Task<VehicleType> AddVehicleTypeAsync(AddVehicleTypeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteVehicleTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method will return all the vehicle types from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type of <see cref="VehicleType"/>.</returns>
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

        public Task<VehicleType> GetVehicleTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleType> GetVehicleTypeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleType> UpdateVehicleTypeAsync(UpdateVehicleTypeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
