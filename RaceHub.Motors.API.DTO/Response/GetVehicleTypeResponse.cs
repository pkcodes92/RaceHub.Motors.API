// <copyright file="GetVehicleTypeResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the API response when getting a single vehicle type.
/// </summary>
public class GetVehicleTypeResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the vehicle type.
    /// </summary>
    [JsonProperty("vehicleType")]
    public VehicleType VehicleType { get; set; }
}
