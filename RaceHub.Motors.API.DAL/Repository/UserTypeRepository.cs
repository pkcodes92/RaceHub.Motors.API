// <copyright file="UserTypeRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
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

        public Task<UserType> AddUserTypeAsync(UserType userType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserType> GetUserTypeByDescription(string description)
        {
            throw new NotImplementedException();
        }

        public Task<UserType> GetUserTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserType>> GetUserTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserType> UpdateUserTypeAsync(UserType userType)
        {
            throw new NotImplementedException();
        }
    }
}
