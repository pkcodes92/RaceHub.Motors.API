// <copyright file="IDrivetrainService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services.Interfaces
{
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;

    /// <summary>
    /// This interface defines methods that interact with the Drivetrain UI entity.
    /// </summary>
    public interface IDrivetrainService
    {
        /// <summary>
        /// This method definition for getting all of the drivetrains from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Drivetrain"/>.</returns>
        Task<List<Drivetrain>> GetAllDrivetrainsAsync();

        /// <summary>
        /// This method definition for getting a single drivetrain by the primary key.
        /// </summary>
        /// <param name="id">The primary key of the drivetrain entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        Task<Drivetrain> GetDrivetrainByIdAsync(int id);

        /// <summary>
        /// This method definition is for adding a new drivetrain to the database.
        /// </summary>
        /// <param name="request">The necessary new information of the drivetrain to be added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        Task<Drivetrain> AddDrivetrainAsync(AddDrivetrainRequest request);

        /// <summary>
        /// This method definition is for updating an existing drivetrain in the database.
        /// </summary>
        /// <param name="request">The request containing the updated drivetrain information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        Task<Drivetrain> UpdateDrivetrainAsync(UpdateDrivetrainRequest request);

        /// <summary>
        /// This method definition removes a drivetrain from the database.
        /// </summary>
        /// <param name="id">The primary key of the drivetrain entity.</param>
        /// <returns>A unit of execution that contains a boolean that indicates successful deletion.</returns>
        Task<bool> DeleteDrivetrainAsync(int id);
    }
}
