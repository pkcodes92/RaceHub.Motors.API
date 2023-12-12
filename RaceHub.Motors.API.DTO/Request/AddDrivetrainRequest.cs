// <copyright file="AddDrivetrainRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents when a new drivetrain is being added to the database.
    /// </summary>
    public class AddDrivetrainRequest
    {
        /// <summary>
        /// Gets or sets the code that is being added for the new drivetrain.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description that is being added for the new drivetrain.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the app name.
        /// </summary>
        [JsonProperty("appName")]
        public string AppName { get; set; }
    }
}
