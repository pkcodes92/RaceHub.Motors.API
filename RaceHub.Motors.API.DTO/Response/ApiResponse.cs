// <copyright file="ApiResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the generic response model.
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation is successful.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
