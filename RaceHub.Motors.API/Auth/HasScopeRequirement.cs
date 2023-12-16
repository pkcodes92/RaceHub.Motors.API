// <copyright file="HasScopeRequirement.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Auth
{
    using Microsoft.AspNetCore.Authorization;

    /// <summary>
    /// This class will make sure to define a scope requirement.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="HasScopeRequirement"/> class.
    /// </remarks>
    /// <param name="scope">The scope of the requirement.</param>
    /// <param name="issuer">The issuer of the token to be validated.</param>
    public class HasScopeRequirement(string scope, string issuer)
        : IAuthorizationRequirement
    {
        /// <summary>
        /// Gets or sets the issuer.
        /// </summary>
        public string Issuer { get; set; } = issuer ?? throw new ArgumentNullException(nameof(issuer));

        /// <summary>
        /// Gets or sets the necessary scope.
        /// </summary>
        public string Scope { get; set; } = scope ?? throw new ArgumentNullException(nameof(scope));
    }
}
