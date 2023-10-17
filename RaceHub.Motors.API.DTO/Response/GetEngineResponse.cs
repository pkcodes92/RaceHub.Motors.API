// <copyright file="GetEngineResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response;

using Newtonsoft.Json;
using RaceHub.Motors.API.DTO.Models;

/// <summary>
/// This class represents the response when getting a single engine.
/// </summary>
public class GetEngineResponse : ApiResponse
{
    /// <summary>
    /// Gets or sets the engine being retrieved.
    /// </summary>
    [JsonProperty("engine")]
    public Engine Engine { get; set; }
}
