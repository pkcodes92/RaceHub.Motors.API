// <copyright file="UpdateManufacturerRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the request when updating a manufacturer.
    /// </summary>
    public class UpdateManufacturerRequest
    {
        /// <summary>
        /// Gets or sets the primary key of the manufacturer entity.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

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
    }
}
