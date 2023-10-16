// <copyright file="Manufacturer.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the Manufacturer UI entity.
    /// </summary>
    public class Manufacturer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
