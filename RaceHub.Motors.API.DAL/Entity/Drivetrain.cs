﻿// <copyright file="Drivetrain.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity;

/// <summary>
/// This class represents the Drivetrain entity.
/// </summary>
public class Drivetrain
{
    /// <summary>
    /// Gets or sets the drivetrain ID - the primary key.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the code of the drivetrain.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the drivetrain is created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the drivetrain is created.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date/time when the drivetrain was previously updated.
    /// </summary>
    public DateTime LastUpd { get; set; }

    /// <summary>
    /// Gets or sets the user/app that previously updated the drivetrain.
    /// </summary>
    public string LastUpdBy { get; set; }

    /// <summary>
    /// Gets or sets the app that previously updated the drivetrain.
    /// </summary>
    public string LastUpdApp { get; set; }
}