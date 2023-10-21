// <copyright file="AddVehicleResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response after adding a new vehicle.
    /// </summary>
    public class AddVehicleResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the vehicle that is added.
        /// </summary>
        [JsonProperty("vehicle")]
        public Vehicle Vehicle { get; set; }
    }
}
