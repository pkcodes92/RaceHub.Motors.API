// <copyright file="LoginRequest.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Request
{
    /// <summary>
    /// This class represents the login request.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Gets or sets the email of the login request.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}
