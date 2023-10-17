// <copyright file="GetManufacturerResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the API response when getting a single manufacturer.
/// </summary>
public class GetManufacturerResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the manufacturer.
    /// </summary>
    [JsonProperty("manufacturer")]
    public Manufacturer Manufacturer { get; set; }
}
