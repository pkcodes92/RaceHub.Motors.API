// <copyright file="GetManufacturersResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;
    using RaceHub.Motors.API.DTO.Models;

    /// <summary>
    /// This class represents the response when getting the manufacturers from the database.
    /// </summary>
    public class GetManufacturersResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the list of manufacturers.
        /// </summary>
        [JsonProperty("manufacturers")]
        public List<Manufacturer> Manufacturers { get; set; }
    }
}
