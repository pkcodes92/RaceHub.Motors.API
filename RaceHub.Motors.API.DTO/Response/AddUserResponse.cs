// <copyright file="AddUserResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response after a user is added.
    /// </summary>
    public class AddUserResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the user being added.
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
