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
        Task<List<User>> GetAllUsersAsync();

        Task<User> AddUserAsync(User user);

        Task<User> UpdateUserAsync(User user);

        Task<User> GetUserByIdAsync(int id);

        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);

        Task<bool> RemoveUserAsync(int id);
    }
}
