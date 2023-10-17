// <copyright file="GetDrivetrainsResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when all the drivetrains are retrieved.
/// </summary>
public class GetDrivetrainsResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the drivetrains from the database.
    /// </summary>
    [JsonProperty("drivetrains")]
    public List<Drivetrain> Drivetrains { get; set; }
}
