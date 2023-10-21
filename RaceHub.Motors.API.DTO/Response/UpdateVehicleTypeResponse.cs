// <copyright file="UpdateVehicleTypeResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when updating a vehicle type.
    /// </summary>
    public class UpdateVehicleTypeResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the updated vehicle type.
        /// </summary>
        [JsonProperty("vehicleType")]
        public VehicleType VehicleType { get; set; }
    }
}
