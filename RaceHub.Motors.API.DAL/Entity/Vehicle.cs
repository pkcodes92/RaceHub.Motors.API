// <copyright file="Vehicle.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity;

/// <summary>
/// This class represents the Vehicle entity.
/// </summary>
public class Vehicle
{
    /// <summary>
    /// Gets or sets the primary key - ID.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer ID.
    /// </summary>
    public int ManufacturerId { get; set; }

    /// <summary>
    /// Gets or sets the name of the vehicle.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the type code.
    /// </summary>
    public string TypeCode { get; set; }

    /// <summary>
    /// Gets or sets the vehicle year.
    /// </summary>
    public int VehYear { get; set; }

    /// <summary>
    /// Gets or sets the image of the vehicle.
    /// </summary>
    public string VehImage { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the vehicle is created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the user/app that created the vehicle.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the vehicle is updated.
    /// </summary>
    public DateTime LastUpd { get; set; }

    /// <summary>
    /// Gets or sets the user/app that previously updated the vehicle.
    /// </summary>
    public string LastUpdBy { get; set; }

    /// <summary>
    /// Gets or sets the app that updated the vehicle.
    /// </summary>
    public string LastUpdApp { get; set; }
}
