// <copyright file="UserRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class would implement methods defined in <see cref="IUserRepository"/>.
    /// </summary>
    /// <param name="context">The database context injection.</param>
    public class UserRepository(RaceHubMotorsContext context)
        : IUserRepository
    {
        private readonly RaceHubMotorsContext context = context;

        /// <summary>
        /// This method implementation adds a new user to the database.
        /// </summary>
        /// <param name="user">The user information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> AddUserAsync(User user)
        {
            this.context.Users.Add(user);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? user : null!;
        }

        /// <summary>
        /// This method implementation gets all the users from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="User"/>.</returns>
        public async Task<List<User>> GetAllUsersAsync()
        {
            var results = await this.context.Users.ToListAsync();
            return results!;
        }

        /// <summary>
        /// This method implementation returns a single user by the email and password.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password (unencrpyted) value of the user.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            var result = await this.context.Users.FirstOrDefaultAsync(g => g.EmailAddress == email && g.Password == password);
            return result!;
        }

        /// <summary>
        /// This method implementation returns a single user by the email address.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <returns>A unit of execution that contains the type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByEmailAsync(string email)
        {
            var result = await this.context.Users.FirstOrDefaultAsync(g => g.EmailAddress == email);
            return result!;
        }

        /// <summary>
        /// This method implementation returns a single user by querying the primary key.
        /// </summary>
        /// <param name="id">The primary key of the user entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByIdAsync(int id)
        {
            var result = await this.context.Users.FirstOrDefaultAsync(g => g.Id == id);
            return result!;
        }

        /// <summary>
        /// This method implementation removes a single user from the database.
        /// </summary>
        /// <param name="id">The primary key of the user entity.</param>
        /// <returns>A unit of execution that contains a boolean that indicates successful deletion.</returns>
        public async Task<bool> RemoveUserAsync(int id)
        {
            this.context.ChangeTracker.Clear();
            var userToDelete = await this.context.Users.FirstOrDefaultAsync(g => g.Id == id);
            this.context.Users.Remove(userToDelete!);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// This method implementation updates a single user in the database.
        /// </summary>
        /// <param name="user">The user information being updated.</param>
        /// <returns>A unit of execution that contains the updated user.</returns>
        public async Task<User> UpdateUserAsync(User user)
        {
            this.context.Users.Update(user);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? user : null!;
        }
    }
}
