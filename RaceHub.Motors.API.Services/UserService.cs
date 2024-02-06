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

        public Task<User> AddUserAsync(AddUserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAdync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(UpdateUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
