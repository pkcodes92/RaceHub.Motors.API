// <copyright file="DeleteDrivetrainResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the API response when deleting a drivetrain.
    /// </summary>
    public class DeleteDrivetrainResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the primary key of the drivetrain entity.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
