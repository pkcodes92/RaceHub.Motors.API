﻿// <copyright file="Drivetrain.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Models;

using Newtonsoft.Json;

/// <summary>
/// This class represents the Drivetrain UI entity.
/// </summary>
public class Drivetrain
{
    /// <summary>
    /// Gets or sets the primary key.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
}
