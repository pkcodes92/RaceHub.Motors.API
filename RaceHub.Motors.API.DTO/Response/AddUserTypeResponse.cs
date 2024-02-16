// <copyright file="AddUserTypeResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response whenever a new user type is added.
    /// </summary>
    public class AddUserTypeResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the newly added user type.
        /// </summary>
        [JsonProperty("userType")]
        public UserType UserType { get; set; }
    }
}
