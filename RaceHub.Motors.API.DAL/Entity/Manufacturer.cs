// <copyright file="Manufacturer.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity
{
    /// <summary>
    /// This class represents the necessary Manufacturer database entity.
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// Gets or sets the primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the image for the manufacturer's nation flag.
        /// </summary>
        public string ManufacturerNationFlag { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer logo.
        /// </summary>
        public string ManufacturerLogo { get; set; }

        /// <summary>
        /// Gets or sets the date/time that the manufacturer is created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the user that created the manufacturer.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date/time that the manufacturer got updated.
        /// </summary>
        public DateTime LastUpd { get; set; }

        /// <summary>
        /// Gets or sets the user that updated the manufacturer.
        /// </summary>
        public string LastUpdBy { get; set; }

        /// <summary>
        /// Gets or sets the application that updated the manufacturer.
        /// </summary>
        public string LastUpdApp { get; set; }
    }
}
