// <copyright file="GetEnginesResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when getting all engines.
/// </summary>
public class GetEnginesResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets all of the engines.
    /// </summary>
    [JsonProperty("engines")]
    public List<Engine> Engines { get; set; }
}
