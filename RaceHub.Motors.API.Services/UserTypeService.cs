// <copyright file="UserTypeService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IUserTypeService"/>.
    /// </summary>
    public class UserTypeService(IUserTypeRepository userTypeRepo)
        : IUserTypeService
    {
        private readonly IUserTypeRepository userTypeRepo = userTypeRepo;

        /// <summary>
        /// This method will add a new user type to the database.
        /// </summary>
        /// <param name="request">The new user type being added to the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> AddUserTypeAsync(AddUserTypeRequest request)
        {
            var entityToAdd = new DAL.Entity.UserType
            {
                Description = request.Description,
                Created = DateTime.Now,
                CreatedBy = request.AppName,
                LastUpd = DateTime.Now,
                LastUpdApp = request.AppName,
                LastUpdBy = request.AppName,
            };

            var dbResult = await this.userTypeRepo.AddUserTypeAsync(entityToAdd!);

            return new UserType
            {
                Description = dbResult.Description,
                Id = dbResult.Id,
            };
        }

        /// <summary>
        /// This method will get a single user type from the database.
        /// </summary>
        /// <param name="description">The description of the user type to search.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> GetUserTypeByDescription(string description)
        {
            var dbResult = await this.userTypeRepo.GetUserTypeByDescription(description);

            return new UserType
            {
                Description = dbResult.Description,
                Id = dbResult.Id,
            };
        }

        /// <summary>
        /// This method will get a single user type from the database.
        /// </summary>
        /// <param name="id">The primary key of the user type entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> GetUserTypeByIdAsync(int id)
        {
            var dbResult = await this.userTypeRepo.GetUserTypeByIdAsync(id);

            return new UserType
            {
                Description = dbResult.Description,
                Id = dbResult.Id,
            };
        }

        /// <summary>
        /// This method will remove a user type from the database.
        /// </summary>
        /// <param name="id">The primary key of the user type entity.</param>
        /// <returns>A unit of execution that contains a boolean indicating successful deletion.</returns>
        public async Task<bool> RemoveUserTypeAsync(int id)
        {
            var result = await this.userTypeRepo.DeleteUserTypeAsync(id);
            return result;
        }

        /// <summary>
        /// This method will update an existing user type in the database.
        /// </summary>
        /// <param name="request">The user type information being updated.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        public async Task<UserType> UpdateUserTypeAsync(UpdateUserTypeRequest request)
        {
            var entityToUpdate = await this.userTypeRepo.GetUserTypeByIdAsync(request.Id);

            entityToUpdate.Description = request.Description;
            entityToUpdate.LastUpd = DateTime.Now;
            entityToUpdate.LastUpdApp = request.AppName;
            entityToUpdate.LastUpdBy = request.AppName;

            var dbResult = await this.userTypeRepo.UpdateUserTypeAsync(entityToUpdate!);

            return new UserType
            {
                Description = dbResult.Description,
                Id = dbResult.Id,
            };
        }
    }
}
