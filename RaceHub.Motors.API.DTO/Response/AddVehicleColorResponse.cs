// <copyright file="AddVehicleColorResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when a new vehicle color is added.
/// </summary>
public class AddVehicleColorResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the newly added vehicle color.
    /// </summary>
    [JsonProperty("vehicleColor")]
    public VehicleColor VehicleColor { get; set; }
}
