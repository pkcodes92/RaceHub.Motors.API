// <copyright file="UserType.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity
{
    /// <summary>
    /// This class represents the user type database entity.
    /// </summary>
    public class UserType
    {
        /// <summary>
        /// Gets or sets the primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date/time that the record has been created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date/time that the record has been updated.
        /// </summary>
        public DateTime LastUpd { get; set; }

        /// <summary>
        /// Gets or sets the last updated by.
        /// </summary>
        public string LastUpdBy { get; set; }

        /// <summary>
        /// Gets or sets the last updated app.
        /// </summary>
        public string LastUpdApp { get; set; }
    }
}
