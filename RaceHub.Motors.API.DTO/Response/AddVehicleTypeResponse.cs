// <copyright file="AddVehicleTypeResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when a new vehicle type is added.
/// </summary>
public class AddVehicleTypeResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the newly added vehicle type.
    /// </summary>
    [JsonProperty("vehicleType")]
    public VehicleType VehicleType { get; set; }
}
