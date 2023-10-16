// <copyright file="VehicleType.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity;

/// <summary>
/// This class represents the vehicle type entity.
/// </summary>
public class VehicleType
{
    /// <summary>
    /// Gets or sets the ID - the primary key.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the type code.
    /// </summary>
    public string TypeCode { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the vehicle type is created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the app/user that created the vehicle type.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the vehicle type has been updated.
    /// </summary>
    public DateTime LastUpd { get; set; }

    /// <summary>
    /// Gets or sets the app/user that updated the vehicle type.
    /// </summary>
    public string LastUpdBy { get; set; }

    /// <summary>
    /// Gets or sets the app that previously updated the vehicle type.
    /// </summary>
    public string LastUpdApp { get; set; }
}
