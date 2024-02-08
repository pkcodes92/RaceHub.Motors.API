// <copyright file="UserService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using System.Threading.Tasks;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class contains the methods that will interact with the User entity.
    /// </summary>
    /// <param name="userRepo">The user repository injection.</param>
    public class UserService(IUserRepository userRepo)
        : IUserService
    {
        private readonly IUserRepository userRepo = userRepo;

        /// <summary>
        /// This method will add a new user to the database.
        /// </summary>
        /// <param name="request">The new user information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> AddUserAsync(AddUserRequest request)
        {
            var userToAdd = new DAL.Entity.User
            {
                Created = DateTime.Now,
                CreatedBy = request.AppName,
                EmailAddress = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                LastUpd = DateTime.Now,
                LastUpdApp = request.AppName,
                LastUpdBy = request.AppName,
                Password = request.Password,
                TypeId = 1,
            };

            var dbResult = await this.userRepo.AddUserAsync(userToAdd);

            return new User
            {
                EmailAddress = dbResult.EmailAddress,
                Password = dbResult.Password,
            };
        }

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password of the user (unencrypted).</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            var dbResult = await this.userRepo.GetUserByEmailAndPasswordAsync(email, password);
            return new User
            {
                EmailAddress = dbResult.EmailAddress,
                Password = dbResult.Password,
            };
        }

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByEmailAsync(string email)
        {
            var dbResult = await this.userRepo.GetUserByEmailAsync(email);

            return new User
            {
                EmailAddress = dbResult.EmailAddress,
                Password = dbResult.Password,
            };
        }

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="id">The primary key of the user entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByIdAdync(int id)
        {
            var dbResult = await this.userRepo.GetUserByIdAsync(id);

            return new User
            {
                Password = dbResult.Password,
                EmailAddress = dbResult.EmailAddress,
            };
        }

        /// <summary>
        /// This method will remove a user from the database.
        /// </summary>
        /// <param name="id">The primary key of the user.</param>
        /// <returns>A unit of execution that contains a boolean indicating successful deletion.</returns>
        public async Task<bool> RemoveUserAsync(int id)
        {
            var result = await this.userRepo.RemoveUserAsync(id);
            return result;
        }

        /// <summary>
        /// This method will update an existing user in the database.
        /// </summary>
        /// <param name="request">The user information being updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> UpdateUserAsync(UpdateUserRequest request)
        {
            var userToUpdate = await this.userRepo.GetUserByIdAsync(request.Id);

            userToUpdate.LastUpd = DateTime.Now;
            userToUpdate.LastUpdApp = request.AppName;
            userToUpdate.LastUpdBy = request.AppName;

            var dbResult = await this.userRepo.UpdateUserAsync(userToUpdate);

            return new User
            {
                EmailAddress = dbResult.EmailAddress,
                Password = dbResult.Password,
            };
        }
    }
}
