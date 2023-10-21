// <copyright file="AddManufacturerResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when the new manufacturer is added.
    /// </summary>
    public class AddManufacturerResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the manufacturer that is added to the database.
        /// </summary>
        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; set; }
    }
}
