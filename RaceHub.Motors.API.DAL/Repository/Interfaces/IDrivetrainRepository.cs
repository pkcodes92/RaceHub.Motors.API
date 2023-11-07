// <copyright file="IDrivetrainRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository.Interfaces
{
    using RaceHub.Motors.API.DAL.Entity;

    /// <summary>
    /// This class represents the methods that interact with the <see cref="Drivetrain"/> entity.
    /// </summary>
    public interface IDrivetrainRepository
    {
        /// <summary>
        /// This method definition returns all the drivetrains from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Drivetrain"/>.</returns>
        Task<List<Drivetrain>> GetAllDrivetrainsAsync();

        /// <summary>
        /// This method definition returns a single drivetrain.
        /// </summary>
        /// <param name="id">The primary key of the drivetrain entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        Task<Drivetrain> GetDrivetrainByIdAsync(int id);

        /// <summary>
        /// This method definition adds a new drivetrain to the database.
        /// </summary>
        /// <param name="drivetrain">The new drivetrain information to add.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        Task<Drivetrain> AddDrivetrainAsync(Drivetrain drivetrain);
    }
}
