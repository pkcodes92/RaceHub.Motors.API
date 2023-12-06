// <copyright file="GetCountryResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents a response getting a single country.
/// </summary>
public class GetCountryResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [JsonProperty("country")]
    public Country Country { get; set; }
}
