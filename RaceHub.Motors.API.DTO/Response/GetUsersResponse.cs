// <copyright file="GetUsersResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when getting all the users from the database.
    /// </summary>
    public class GetUsersResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the list of users.
        /// </summary>
        [JsonProperty("users")]
        public List<User> Users { get; set; }
    }
}
