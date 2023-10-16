// <copyright file="Manufacturer.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Models;

using Newtonsoft.Json;

/// <summary>
/// This class represents the Manufacturer UI entity.
/// </summary>
public class Manufacturer
{
    /// <summary>
    /// Gets or sets the necessary primary key.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    [JsonProperty("region")]
    public string Region { get; set; }

    /// <summary>
    /// Gets or sets the flag.
    /// </summary>
    [JsonProperty("flag")]
    public string Flag { get; set; }

    /// <summary>
    /// Gets or sets the logo.
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [JsonProperty("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the name of the manufacturer.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
}
