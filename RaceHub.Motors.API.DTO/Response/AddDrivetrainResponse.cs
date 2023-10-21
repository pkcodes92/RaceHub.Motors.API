// <copyright file="AddDrivetrainResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when adding a drivetrain.
    /// </summary>
    public class AddDrivetrainResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the drivetrain that is added.
        /// </summary>
        [JsonProperty("drivetrain")]
        public Drivetrain Drivetrain { get; set; }
    }
}
