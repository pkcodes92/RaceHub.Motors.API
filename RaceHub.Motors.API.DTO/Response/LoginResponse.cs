// <copyright file="LoginResponse.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DTO.Response
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents the successful login response.
    /// </summary>
    public class LoginResponse : ApiResponse
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the first name of the logged in user.
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the logged in user.
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user type.
        /// </summary>
        [JsonProperty("userType")]
        public string UserType { get; set; }
    }
}
