// <copyright file="DeleteVehicleResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the response when a vehicle is deleted.
    /// </summary>
    public class DeleteVehicleResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the primary key.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
