// <copyright file="AddVehicleRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the request when adding a new vehicle.
    /// </summary>
    public class AddVehicleRequest
    {
        /// <summary>
        /// Gets or sets the manufacturer name.
        /// </summary>
        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the vehicle name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the vehicle type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the vehicle year.
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the image of the vehicle.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the application name.
        /// </summary>
        [JsonProperty("appName")]
        public string AppName { get; set; }
    }
}
