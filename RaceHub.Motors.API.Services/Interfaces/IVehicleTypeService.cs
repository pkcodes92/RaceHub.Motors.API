// <copyright file="IVehicleTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This interface defines the methods for interacting with the Vehicle Type UI entity.
    /// </summary>
    public interface IVehicleTypeService
    {
        Task<List<VehicleType>> GetAllVehicleTypesAsync();
    }
}
