// <copyright file="HasScopeHandler.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Auth
{
    using Microsoft.AspNetCore.Authorization;

    /// <summary>
    /// This class will make sure to have all of the scopes correctly.
    /// </summary>
    public class HasScopeHandler : AuthorizationHandler<HasScopeRequirement>
    {
        /// <summary>
        /// This method will make sure to handle the appropriate context requirements.
        /// </summary>
        /// <param name="context">The current authorization context.</param>
        /// <param name="requirement">The necessary scope requirements.</param>
        /// <returns>A unit of execution.</returns>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasScopeRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == "scope" && c.Issuer == requirement.Issuer))
            {
                return Task.CompletedTask;
            }

            // Split the scope strings into an array.
            var scopes = context.User.FindFirst(c => c.Type == "scope" && c.Issuer == requirement.Issuer)?.Value.Split(' ');

            // Succeed if the scope array contains the required scope
            if (scopes!.Any(s => s == requirement.Scope))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
