// <copyright file="UserService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class contains the methods that will interact with the User entity.
    /// </summary>
    /// <param name="userRepo">The user repository injection.</param>
    /// <param name="userTypeRepo">The user type repository injection.</param>
    public class UserService(IUserRepository userRepo, IUserTypeRepository userTypeRepo)
        : IUserService
    {
        private readonly IUserRepository userRepo = userRepo;
        private readonly IUserTypeRepository userTypeRepo = userTypeRepo;

        /// <summary>
        /// This method will add a new user to the database.
        /// </summary>
        /// <param name="request">The new user information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> AddUserAsync(AddUserRequest request)
        {
            var userType = await this.userTypeRepo.GetUserTypeByDescription(request.UserType);

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
                TypeId = userType.Id,
            };

            var dbResult = await this.userRepo.AddUserAsync(userToAdd);

            return new User
            {
                Id = dbResult.Id,
                FirstName = dbResult.FirstName,
                LastName = dbResult.LastName,
                Email = dbResult.EmailAddress,
                Password = dbResult.Password,
                Type = userType.Description,
            };
        }

        /// <summary>
        /// This method will get all of the users.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="User"/>.</returns>
        public async Task<List<User>> GetAllUsersAsync()
        {
            var dbResults = await this.userRepo.GetAllUsersAsync();
            var results = new List<User>();

            foreach (var user in dbResults)
            {
                var userType = await this.userTypeRepo.GetUserTypeByIdAsync(user.TypeId);

                var userToAdd = new User
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.EmailAddress,
                    Password = user.Password,
                    Type = userType.Description,
                };

                results.Add(userToAdd);
            }

            return results;
        }

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password of the user (unencrypted).</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            var dbUser = await this.userRepo.GetUserByEmailAndPasswordAsync(email, password);
            var dbUserType = await this.userTypeRepo.GetUserTypeByIdAsync(dbUser.TypeId);

            return new User
            {
                Id = dbUser.Id,
                FirstName = dbUser.FirstName,
                LastName = dbUser.LastName,
                Email = dbUser.EmailAddress,
                Password = dbUser.Password,
                Type = dbUserType.Description,
            };
        }

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByEmailAsync(string email)
        {
            var dbUser = await this.userRepo.GetUserByEmailAsync(email);
            var dbUserType = await this.userTypeRepo.GetUserTypeByIdAsync(dbUser.TypeId);

            return new User
            {
                Id = dbUser.Id,
                FirstName = dbUser.FirstName,
                LastName = dbUser.LastName,
                Email = dbUser.EmailAddress,
                Password = dbUser.Password,
                Type = dbUserType.Description,
            };
        }

        /// <summary>
        /// This method will get a single user from the database.
        /// </summary>
        /// <param name="id">The primary key of the user entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="User"/>.</returns>
        public async Task<User> GetUserByIdAdync(int id)
        {
            var dbUser = await this.userRepo.GetUserByIdAsync(id);
            var dbUserType = await this.userTypeRepo.GetUserTypeByIdAsync(dbUser.TypeId);

            return new User
            {
                Id = dbUser.Id,
                FirstName = dbUser.FirstName,
                LastName = dbUser.LastName,
                Password = dbUser.Password,
                Email = dbUser.EmailAddress,
                Type = dbUserType.Description,
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

            userToUpdate.Password = request.UpdatedPassword;
            userToUpdate.LastUpd = DateTime.Now;
            userToUpdate.LastUpdApp = request.AppName;
            userToUpdate.LastUpdBy = request.AppName;

            var dbUser = await this.userRepo.UpdateUserAsync(userToUpdate);
            var dbUserType = await this.userTypeRepo.GetUserTypeByIdAsync(dbUser.TypeId);

            return new User
            {
                Id = dbUser.Id,
                FirstName = dbUser.FirstName,
                LastName = dbUser.LastName,
                Email = dbUser.EmailAddress,
                Password = dbUser.Password,
                Type = dbUserType.Description,
            };
        }
    }
}
