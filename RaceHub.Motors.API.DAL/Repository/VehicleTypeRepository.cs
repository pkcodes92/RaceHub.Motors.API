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
    /// Initializes a new instance of the <see cref="VehicleTypeRepository"/> class.
    /// </summary>
    /// <param name="context">The database context injection.</param>
    public class VehicleTypeRepository(RaceHubMotorsContext context)
        : IVehicleTypeRepository
    {
        private readonly RaceHubMotorsContext context = context;

        /// <summary>
        /// This method implementation will add a new vehicle to the database.
        /// </summary>
        /// <param name="vehicleType">The vehicle type being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> AddVehicleTypeAsync(VehicleType vehicleType)
        {
            this.context.VehicleTypes.Add(vehicleType);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? vehicleType : null!;
        }

        /// <summary>
        /// This method implementation will remove a vehicle type from the database.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        public async Task<bool> DeleteVehicleTypeAsync(int id)
        {
            this.context.ChangeTracker.Clear();
            var vehicleTypeToDelete = await this.context.VehicleTypes.FirstOrDefaultAsync(g => g.Id == id);
            this.context.VehicleTypes.Remove(vehicleTypeToDelete!);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// This method will return all of the vehicle types in the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="VehicleType"/>.</returns>
        public async Task<List<VehicleType>> GetAllVehicleTypesAsync()
        {
            var results = await this.context.VehicleTypes.ToListAsync();
            return results!;
        }

        /// <summary>
        /// This method implementation will return a single vehicle type.
        /// </summary>
        /// <param name="id">The primary key of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> GetVehicleTypeAsync(int id)
        {
            var result = await this.context.VehicleTypes.FirstOrDefaultAsync(g => g.Id == id);
            return result!;
        }

        /// <summary>
        /// This method implementation will get a single vehicle type.
        /// </summary>
        /// <param name="code">The type code of the vehicle type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> GetVehicleTypeAsync(string code)
        {
            var result = await this.context.VehicleTypes.FirstOrDefaultAsync(g => g.TypeCode == code);
            return result!;
        }

        /// <summary>
        /// This method implementation will update an existing vehicle type in the database.
        /// </summary>
        /// <param name="vehicleType">The vehicle type information to update.</param>
        /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
        public async Task<VehicleType> UpdateVehicleTypeAsync(VehicleType vehicleType)
        {
            this.context.VehicleTypes.Update(vehicleType);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? vehicleType : null!;
        }
    }
}
