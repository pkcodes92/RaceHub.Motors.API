// <copyright file="VehicleColor.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity;

/// <summary>
/// This class represents the Vehicle Color entity.
/// </summary>
public class VehicleColor
{
    /// <summary>
    /// Gets or sets the primary key - ID.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the date/time created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the app/user that created the vehicle color.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the vehicle color is updated.
    /// </summary>
    public DateTime LastUpd { get; set; }

    /// <summary>
    /// Gets or sets the app/user that updated the vehicle color.
    /// </summary>
    public string LastUpdBy { get; set; }

    /// <summary>
    /// Gets or sets the app that last updated the vehicle color.
    /// </summary>
    public string LastUpdApp { get; set; }
}