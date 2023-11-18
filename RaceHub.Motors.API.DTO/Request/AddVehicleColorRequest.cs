// <copyright file="AddVehicleColorRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the time when a new vehicle color is being added to the database.
    /// </summary>
    public class AddVehicleColorRequest
    {
        /// <summary>
        /// Gets or sets the code of the new vehicle color to add.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the new vehicle color to add.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the application name.
        /// </summary>
        [JsonProperty("appName")]
        public string AppName { get; set; }
    }
}
