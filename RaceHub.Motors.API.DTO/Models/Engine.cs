// <copyright file="Engine.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Models;

using Newtonsoft.Json;

/// <summary>
/// This class represents the Engine UI entity.
/// </summary>
public class Engine
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the engine code.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the engine description.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
}
