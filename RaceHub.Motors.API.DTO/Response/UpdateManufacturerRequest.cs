// <copyright file="UpdateManufacturerRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when a manufacturer is updated.
    /// </summary>
    public class UpdateManufacturerRequest : ApiResponse
    {
        /// <summary>
        /// Gets or sets the updated manufacturer.
        /// </summary>
        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; set; }
    }
}
