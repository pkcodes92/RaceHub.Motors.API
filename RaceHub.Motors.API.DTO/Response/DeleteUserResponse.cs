// <copyright file="DeleteUserResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;

    /// <summary>
    /// This method represents the response when a user is deleted.
    /// </summary>
    public class DeleteUserResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the primary key of the user entity.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
