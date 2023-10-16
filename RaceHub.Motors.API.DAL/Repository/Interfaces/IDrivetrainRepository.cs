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
        /// <returns></returns>
        Task<List<Drivetrain>> GetAllDrivetrainsAsync();

        Task<Drivetrain> GetDrivetrainByIdAsync(int id);
    }
}
