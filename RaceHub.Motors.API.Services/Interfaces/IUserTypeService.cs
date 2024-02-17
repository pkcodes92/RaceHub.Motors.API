// <copyright file="IUserTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

    /// <summary>
    /// This interface contains methods that interact with the User Type UI entity.
    /// </summary>
    public interface IUserTypeService
    {
        /// <summary>
        /// This method definition adds a new user type to the database.
        /// </summary>
        /// <param name="request">The new user type information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> AddUserTypeAsync(AddUserTypeRequest request);

        /// <summary>
        /// This method definition gets a single user type by the ID.
        /// </summary>
        /// <param name="id">The primary key of the user type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> GetUserTypeByIdAsync(int id);

        /// <summary>
        /// This method definition will update a user type in the database.
        /// </summary>
        /// <param name="request">The update user type information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> UpdateUserTypeAsync(UpdateUserTypeRequest request);

        /// <summary>
        /// This method definition will get a user type by the description.
        /// </summary>
        /// <param name="description">The user type description.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> GetUserTypeByDescription(string description);

        /// <summary>
        /// This method definition will remove a user type from the database.
        /// </summary>
        /// <param name="id">The primary key of the user type entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        Task<bool> RemoveUserTypeAsync(int id);
    }
}
