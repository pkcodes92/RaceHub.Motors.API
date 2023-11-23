// <copyright file="VehicleColorService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
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

        /// <summary>
        /// This method adds a new vehicle color to the database.
        /// </summary>
        /// <param name="request">The new vehicle color information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        public async Task<VehicleColor> AddVehicleColorAsync(AddVehicleColorRequest request)
        {
            var vehicleColor = new DAL.Entity.VehicleColor
            {
                Code = request.Code,
                Description = request.Description,
                Created = DateTime.Now,
                CreatedBy = request.AppName,
                LastUpd = DateTime.Now,
                LastUpdApp = request.AppName,
                LastUpdBy = request.AppName,
            };

            var dbResult = await this.vehicleColorRepo.AddVehicleColorAsync(vehicleColor);

            return new VehicleColor
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method updates a vehicle color in the database.
        /// </summary>
        /// <param name="request">The updated vehicle color information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
        public async Task<VehicleColor> UpdateVehicleColorAsync(UpdateVehicleColorRequest request)
        {
            var vehicleColorToUpdate = await this.vehicleColorRepo.GetVehicleColorByIdAsync(request.Id);

            vehicleColorToUpdate.Code = request.Code;
            vehicleColorToUpdate.Description = request.Description;
            vehicleColorToUpdate.LastUpd = DateTime.Now;
            vehicleColorToUpdate.LastUpdBy = request.AppName;
            vehicleColorToUpdate.LastUpdApp = request.AppName;
            vehicleColorToUpdate.Id = request.Id;

            var dbResult = await this.vehicleColorRepo.UpdateVehicleColorAsync(vehicleColorToUpdate);

            return new VehicleColor
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method will remove a vehicle color from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle color entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        public async Task<bool> DeleteVehicleColorAsync(int id)
        {
            var dbResult = await this.vehicleColorRepo.DeleteVehicleColorAsync(id);
            return dbResult;
        }
    }
}
