// <copyright file="GetCountriesResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the response when getting the manufacturing countries.
    /// </summary>
    public class GetCountriesResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the list of countries.
        /// </summary>
        [JsonProperty("countries")]
        public List<Country> Countries { get; set; }
    }
}
