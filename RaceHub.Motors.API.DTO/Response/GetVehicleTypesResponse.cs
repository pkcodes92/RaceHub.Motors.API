// <copyright file="GetVehicleTypesResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when getting all the vehicle types.
/// </summary>
public class GetVehicleTypesResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets all the vehicle types from the database.
    /// </summary>
    [JsonProperty("vehicleTypes")]
    public List<VehicleType> VehicleTypes { get; set; }
}
