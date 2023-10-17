// <copyright file="GetVehicleColorResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when getting a single Vehicle Color from the database.
/// </summary>
public class GetVehicleColorResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the vehicle color retrieved from the database.
    /// </summary>
    [JsonProperty("vehicleColor")]
    public VehicleColor VehicleColor { get; set; }
}
