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
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer name.
    /// </summary>
    public string Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the name of the vehicle.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the vehicle type code.
    /// </summary>
    public string TypeCode { get; set; }

    /// <summary>
    /// Gets or sets the image of the vehicle.
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    /// Gets or sets the year of the vehicle.
    /// </summary>
    public int Year { get; set; }
}
