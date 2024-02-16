// <copyright file="UpdateUserTypeResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when a user type is updated in the database.
    /// </summary>
    public class UpdateUserTypeResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the user type.
        /// </summary>
        [JsonProperty("userType")]
        public UserType UserType { get; set; }
    }
}
