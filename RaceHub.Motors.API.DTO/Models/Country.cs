// <copyright file="Country.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DTO
{
    /// <summary>
    /// This class represents the country UI entity.
    /// </summary>
    public class Country
    {
        public string Name { get; set; }

        public string Region { get; set; }

        public string CountryCode { get; set; }

        public string Flag { get; set; }
    }
}
