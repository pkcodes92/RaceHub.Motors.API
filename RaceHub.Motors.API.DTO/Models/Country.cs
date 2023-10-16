// <copyright file="Country.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO;

using Newtonsoft.Json;

/// <summary>
/// This class represents the country UI entity.
/// </summary>
public class Country
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    [JsonProperty("region")]
    public string Region { get; set; }

    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the flag image URL.
    /// </summary>
    [JsonProperty("flag")]
    public string Flag { get; set; }
}
