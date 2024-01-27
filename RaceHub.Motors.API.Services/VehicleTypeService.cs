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

        /// <summary>
        /// This method will add a new vehicle type to the database.
        /// </summary>
        /// <param name="request">The new vehicle type information to add.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> AddVehicleTypeAsync(AddVehicleTypeRequest request)
        {
            var vehicleTypeToAdd = new DAL.Entity.VehicleType
            {
                Created = DateTime.Now,
                CreatedBy = request.AppName,
                Description = request.Description,
                TypeCode = request.Code,
                LastUpd = DateTime.Now,
                LastUpdApp = request.AppName,
                LastUpdBy = request.AppName,
            };

            var dbResult = await this.vehicleTypeRepo.AddVehicleTypeAsync(vehicleTypeToAdd);

            return new VehicleType
            {
                Id = dbResult.Id,
                Code = dbResult.TypeCode,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method will remove a vehicle type from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains a boolean which indicates successful deletion.</returns>
        public async Task<bool> DeleteVehicleTypeAsync(int id)
        {
            var result = await this.vehicleTypeRepo.DeleteVehicleTypeAsync(id);
            return result;
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

        /// <summary>
        /// This method will return a single vehicle type from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> GetVehicleTypeAsync(int id)
        {
            var dbResult = await this.vehicleTypeRepo.GetVehicleTypeAsync(id);

            return new VehicleType
            {
                Id = dbResult.Id,
                Code = dbResult.TypeCode,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method will return a single vehicle type from the database.
        /// </summary>
        /// <param name="code">The code by which to search the vehicle types.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> GetVehicleTypeAsync(string code)
        {
            var dbResult = await this.vehicleTypeRepo.GetVehicleTypeAsync(code);

            return new VehicleType
            {
                Id = dbResult.Id,
                Code = dbResult.TypeCode,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method will update an existing vehicle type in the database.
        /// </summary>
        /// <param name="request">The vehicle type information being updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> UpdateVehicleTypeAsync(UpdateVehicleTypeRequest request)
        {
            var vehicleTypeToUpdate = await this.vehicleTypeRepo.GetVehicleTypeAsync(request.Id);

            vehicleTypeToUpdate.LastUpd = DateTime.Now;
            vehicleTypeToUpdate.LastUpdBy = request.AppName;
            vehicleTypeToUpdate.LastUpdApp = request.AppName;
            vehicleTypeToUpdate.Description = request.Description;

            var dbResult = await this.vehicleTypeRepo.UpdateVehicleTypeAsync(vehicleTypeToUpdate);

            return new VehicleType
            {
                Id = dbResult.Id,
                Code = dbResult.TypeCode,
                Description = dbResult.Description,
            };
        }
    }
}
