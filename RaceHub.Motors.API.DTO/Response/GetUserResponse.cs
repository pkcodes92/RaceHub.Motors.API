// <copyright file="GetUserResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response of getting a single user.
    /// </summary>
    public class GetUserResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
