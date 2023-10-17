// <copyright file="GetVehicleColorsResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when getting all the vehicle colors.
/// </summary>
public class GetVehicleColorsResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the vehicle colors.
    /// </summary>
    [JsonProperty("vehicleColors")]
    public List<VehicleColor> VehicleColors { get; set; }
}
