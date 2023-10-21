// <copyright file="Vehicle.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Models;

using Newtonsoft.Json;

/// <summary>
/// This class represents the Vehicle UI entity.
/// </summary>
public class Vehicle
{
    /// <summary>
    /// Gets or sets the primary key.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer name.
    /// </summary>
    [JsonProperty("manufacturer")]
    public string Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the name of the vehicle.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the vehicle type code.
    /// </summary>
    [JsonProperty("typeCode")]
    public string TypeCode { get; set; }

    /// <summary>
    /// Gets or sets the image of the vehicle.
    /// </summary>
    [JsonProperty("image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or sets the year of the vehicle.
    /// </summary>
    [JsonProperty("year")]
    public int Year { get; set; }
}
