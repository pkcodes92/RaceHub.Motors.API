// <copyright file="User.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the user entity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
