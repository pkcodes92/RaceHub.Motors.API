// <copyright file="UserTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IUserTypeService"/>.
    /// </summary>
    public class UserTypeService : IUserTypeService
    {
        public Task<UserType> AddUserTypeAsync(AddUserTypeRequest request)
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

        public Task<bool> RemoveUserTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserType> UpdateUserTypeAsync(UpdateUserTypeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
