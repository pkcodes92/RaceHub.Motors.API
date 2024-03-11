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
        /// <summary>
        /// This method definition will get all of the user types from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="UserType"/>.</returns>
        Task<List<UserType>> GetUserTypesAsync();

        /// <summary>
        /// This method definition will add a user type to the database.
        /// </summary>
        /// <param name="userType">The user type being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> AddUserTypeAsync(UserType userType);

        /// <summary>
        /// This method definition will update an existing user type.
        /// </summary>
        /// <param name="userType">The user type information to update.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> UpdateUserTypeAsync(UserType userType);

        /// <summary>
        /// This method definition will get a singe user type.
        /// </summary>
        /// <param name="id">The primary key of the <see cref="UserType"/> entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> GetUserTypeByIdAsync(int id);

        /// <summary>
        /// This method definition will get a single user type by the description.
        /// </summary>
        /// <param name="description">The description of the user type to search.</param>
        /// <returns>A unit of execution that contains a type of <see cref="UserType"/>.</returns>
        Task<UserType> GetUserTypeByDescription(string description);

        /// <summary>
        /// This method definition will remove a user type from the database.
        /// </summary>
        /// <param name="id">The primary key of the <see cref="UserType"/> entity.</param>
        /// <returns>A unit of execution that contains a boolean indicating a successful deletion.</returns>
        Task<bool> DeleteUserTypeAsync(int id);
    }
}
