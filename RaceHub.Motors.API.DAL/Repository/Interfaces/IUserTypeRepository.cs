// <copyright file="IUserTypeRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This interface defines the methods that interact with the User Type database entity.
    /// </summary>
    public interface IUserTypeRepository
    {
        Task<List<UserType>> GetUserTypesAsync();

        Task<UserType> AddUserTypeAsync(UserType userType);

        Task<UserType> UpdateUserTypeAsync(UserType userType);

        Task<UserType> GetUserTypeByIdAsync(int id);

        Task<UserType> GetUserTypeByDescription(string description);

        Task<bool> DeleteUserTypeAsync(int id);
    }
}
