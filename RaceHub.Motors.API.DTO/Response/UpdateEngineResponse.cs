// <copyright file="UpdateEngineResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when updating an engine.
    /// </summary>
    public class UpdateEngineResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the updated engine.
        /// </summary>
        [JsonProperty("engine")]
        public Engine Engine { get; set; }
    }
}
