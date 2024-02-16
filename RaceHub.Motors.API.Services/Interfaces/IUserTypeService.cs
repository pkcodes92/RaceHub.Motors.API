// <copyright file="IUserTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

    /// <summary>
    /// This interface contains methods that interact with the User Type UI entity.
    /// </summary>
    public interface IUserTypeService
    {
        Task<UserType> AddUserTypeAsync(AddUserTypeRequest request);

        Task<UserType> GetUserTypeByIdAsync(int id);

        Task<UserType> UpdateUserTypeAsync(UpdateUserTypeRequest request);

        Task<UserType> GetUserTypeByDescription(string description);

        Task<bool> RemoveUserTypeAsync(int id);
    }
}
