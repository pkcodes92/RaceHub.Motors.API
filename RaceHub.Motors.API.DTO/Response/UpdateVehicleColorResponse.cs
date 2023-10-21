// <copyright file="UpdateVehicleColorResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents when a vehicle color is updated.
    /// </summary>
    public class UpdateVehicleColorResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the updated vehicle color.
        /// </summary>
        [JsonProperty("vehicleColor")]
        public VehicleColor VehicleColor { get; set; }
    }
}
