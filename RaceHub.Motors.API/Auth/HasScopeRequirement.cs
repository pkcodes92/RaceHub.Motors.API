// <copyright file="HasScopeRequirement.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Auth
{
    using Microsoft.AspNetCore.Authorization;

    public class HasScopeRequirement : IAuthorizationRequirement
    {
        public string Issuer { get; set; }

        public string Scope { get; set; }

        public HasScopeRequirement(string scope, string issuer)
        {
            this.Scope = scope ?? throw new ArgumentNullException(nameof(scope));
            this.Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
        }
    }
}
