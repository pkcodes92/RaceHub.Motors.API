// <copyright file="UpdateUserResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when a user is updated.
    /// </summary>
    public class UpdateUserResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the updated user.
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
