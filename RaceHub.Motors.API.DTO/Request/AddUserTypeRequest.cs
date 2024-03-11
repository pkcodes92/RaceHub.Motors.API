// <copyright file="AddUserTypeRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the request when adding a user type.
    /// </summary>
    public class AddUserTypeRequest
    {
        /// <summary>
        /// Gets or sets the description to add.
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
