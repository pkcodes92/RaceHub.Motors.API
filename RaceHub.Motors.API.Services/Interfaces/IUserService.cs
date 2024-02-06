// <copyright file="IUserService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

    /// <summary>
    /// This class defines the methods that interact with the user entity.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// This method will add a new user to the database.
        /// </summary>
        /// <param name="request">The new user information to save in the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> AddUserAsync(AddUserRequest request);

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="id">The primary key of the user entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> GetUserByIdAdync(int id);

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> GetUserByEmailAsync(string email);

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A unit of execution that contains type of <see cref="User"/>.</returns>
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);

        /// <summary>
        /// This method will update a user in the database.
        /// </summary>
        /// <param name="request">The updated user information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> UpdateUserAsync(UpdateUserRequest request);

        /// <summary>
        /// This method will remove a user from the database.
        /// </summary>
        /// <param name="id">The primary key of the user entity.</param>
        /// <returns>A unit of execution that contains a boolean that indicates successful deletion.</returns>
        Task<bool> RemoveUserAsync(int id);
    }
}
