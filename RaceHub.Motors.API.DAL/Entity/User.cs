// <copyright file="User.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity
{
    /// <summary>
    /// This class represents the User db entity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the type ID.
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets the date/time that the user is created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets who has created the user.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date/time that the user was updated.
        /// </summary>
        public DateTime LastUpd { get; set; }

        /// <summary>
        /// Gets or sets who has updated the user.
        /// </summary>
        public string LastUpdBy { get; set; }

        /// <summary>
        /// Gets or sets the app which updated the user.
        /// </summary>
        public string LastUpdApp { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}
