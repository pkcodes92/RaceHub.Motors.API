// <copyright file="UserTypeRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IUserTypeRepository"/>.
    /// </summary>
    /// <param name="context">The database context injection.</param>
    public class UserTypeRepository(RaceHubMotorsContext context)
        : IUserTypeRepository
    {
        private readonly RaceHubMotorsContext context = context;

        /// <summary>
        /// This method will be adding the user type to the database.
        /// </summary>
        /// <param name="userType">The new user type information to add.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> AddUserTypeAsync(UserType userType)
        {
            this.context.UserTypes.Add(userType);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? userType : null!;
        }

        /// <summary>
        /// This method will remove a user type from the database.
        /// </summary>
        /// <param name="id">The primary key of the user type entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        public async Task<bool> DeleteUserTypeAsync(int id)
        {
            this.context.ChangeTracker.Clear();
            var entityToDelete = await this.context.UserTypes.FirstOrDefaultAsync(x => x.Id == id);
            this.context.UserTypes.Remove(entityToDelete!);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// This method will get a single user type from the database.
        /// </summary>
        /// <param name="description">The description to search the user types for.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> GetUserTypeByDescription(string description)
        {
            var result = await this.context.UserTypes.FirstOrDefaultAsync(g => g.Description == description);
            return result!;
        }

        /// <summary>
        /// This method will get a single user type from the database.
        /// </summary>
        /// <param name="id">The primary key of the user type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> GetUserTypeByIdAsync(int id)
        {
            var result = await this.context.UserTypes.FirstOrDefaultAsync(g => g.Id == id);
            return result!;
        }

        /// <summary>
        /// This method will return all of the user types from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="UserType"/>.</returns>
        public async Task<List<UserType>> GetUserTypesAsync()
        {
            var results = await this.context.UserTypes.ToListAsync();
            return results!;
        }

        /// <summary>
        /// This method will update an existing user type in the database.
        /// </summary>
        /// <param name="userType">The user type to update.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> UpdateUserTypeAsync(UserType userType)
        {
            this.context.UserTypes.Update(userType);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? userType : null!;
        }
    }
}
