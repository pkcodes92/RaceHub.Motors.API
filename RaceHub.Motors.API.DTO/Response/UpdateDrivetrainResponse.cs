// <copyright file="UpdateDrivetrainResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class will represent the response when updating a drivetrain.
    /// </summary>
    public class UpdateDrivetrainResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the updated drivetrain.
        /// </summary>
        [JsonProperty("drivetrain")]
        public Drivetrain Drivetrain { get; set; }
    }
}
