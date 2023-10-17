// <copyright file="GetDrivetrainResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when the API gets a single drivetrain.
/// </summary>
public class GetDrivetrainResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the single drivetrain from the database.
    /// </summary>
    [JsonProperty("drivetrain")]
    public Drivetrain Drivetrain { get; set; }
}
