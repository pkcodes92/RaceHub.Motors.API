// <copyright file="IUserRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This interface defines the methods interact with the User entity in the database.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// This method definition will get all of the users from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="User"/>.</returns>
        Task<List<User>> GetAllUsersAsync();

        /// <summary>
        /// This method definition will add a new user to the database.
        /// </summary>
        /// <param name="user">The new user information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> AddUserAsync(User user);

        /// <summary>
        /// This method definition will update an existing user in the database.
        /// </summary>
        /// <param name="user">The user information being updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> UpdateUserAsync(User user);

        /// <summary>
        /// This method definition will get a single user from the database.
        /// </summary>
        /// <param name="id">The primary key of the <see cref="User"/> entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> GetUserByIdAsync(int id);

        /// <summary>
        /// This method definition will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user to search.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        Task<User> GetUserByEmailAsync(string email);

        /// <summary>
        /// This method definition will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A unit of execution that contains the type of <see cref="User"/>.</returns>
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);

        /// <summary>
        /// This method definition will remove a user from the database.
        /// </summary>
        /// <param name="id">The primary key of the <see cref="User"/> entity.</param>
        /// <returns>A unit of execution that contains a value indicating successful deletion.</returns>
        Task<bool> RemoveUserAsync(int id);
    }
}
