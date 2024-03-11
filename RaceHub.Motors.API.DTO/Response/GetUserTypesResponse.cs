// <copyright file="GetUserTypesResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when getting all the user types.
    /// </summary>
    public class GetUserTypesResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the user types.
        /// </summary>
        [JsonProperty("userTypes")]
        public List<UserType> UserTypes { get; set; }
    }
}
