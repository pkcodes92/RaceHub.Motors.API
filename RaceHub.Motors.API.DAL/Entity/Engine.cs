// <copyright file="Engine.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity;

/// <summary>
/// This class represents the necessary Engine DB entity.
/// </summary>
public class Engine
{
    /// <summary>
    /// Gets or sets the ID - the primary key.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the code of the engine.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description of the engine.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the engine is created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the app/user that created the engine.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date/time that the engine is updated.
    /// </summary>
    public DateTime LastUpd { get; set; }

    /// <summary>
    /// Gets or sets the app/user that updated the engine.
    /// </summary>
    public string LastUpdBy { get; set; }

    /// <summary>
    /// Gets or sets the application that updated the engine.
    /// </summary>
    public string LastUpdApp { get; set; }
}