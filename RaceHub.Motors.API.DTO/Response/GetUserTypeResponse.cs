// <copyright file="GetUserTypeResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the necessary model when getting a single user type.
    /// </summary>
    public class GetUserTypeResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the single user type.
        /// </summary>
        [JsonProperty("userType")]
        public UserType UserType { get; set; }
    }
}
