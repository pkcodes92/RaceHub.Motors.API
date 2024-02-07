// <copyright file="UpdateUserRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the request when a user is updated.
    /// </summary>
    public class UpdateUserRequest
    {
        /// <summary>
        /// Gets or sets the primary key of the user entity.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the app name.
        /// </summary>
        [JsonProperty("appName")]
        public string AppName { get; set; }
    }
}
