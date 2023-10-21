// <copyright file="UpdateVehicleResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when a vehicle color is updated.
    /// </summary>
    public class UpdateVehicleResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the updated vehicle.
        /// </summary>
        [JsonProperty("vehicle")]
        public Vehicle Vehicle { get; set; }
    }
}
