// <copyright file="AddEngineRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    using Newtonsoft.Json;

    /// <summary>
    /// This model represents the request that is being made when adding a new engine to the database.
    /// </summary>
    public class AddEngineRequest
    {
        /// <summary>
        /// Gets or sets the necessary code of the new engine being added.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the new engine being added.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
