// <copyright file="AddEngineResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when adding an engine.
    /// </summary>
    public class AddEngineResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the newly added engine.
        /// </summary>
        [JsonProperty("engine")]
        public Engine Engine { get; set; }
    }
}
