﻿// <copyright file="DrivetrainService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IDrivetrainService"/>.
    /// </summary>
    public class DrivetrainService : IDrivetrainService
    {
        private readonly IDrivetrainRepository drivetrainRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrivetrainService"/> class.
        /// </summary>
        /// <param name="drivetrainRepo">The drivetrain repository injection.</param>
        public DrivetrainService(IDrivetrainRepository drivetrainRepo)
        {
            this.drivetrainRepo = drivetrainRepo;
        }

        /// <summary>
        /// This method implementation gets all of the drivetrains from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Drivetrain"/>.</returns>
        public async Task<List<Drivetrain>> GetAllDrivetrainsAsync()
        {
            var dbResults = await this.drivetrainRepo.GetAllDrivetrainsAsync();
            var results = new List<Drivetrain>();

            foreach (var item in dbResults)
            {
                var itemToAdd = new Drivetrain
                {
                    Code = item.Code,
                    Description = item.Description,
                    Id = item.Id,
                };

                results.Add(itemToAdd);
            }

            return results!;
        }

        /// <summary>
        /// This method implementation gets a single drivetrain from the database.
        /// </summary>
        /// <param name="id">The primary key of the drivetrain UI entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        public async Task<Drivetrain> GetDrivetrainByIdAsync(int id)
        {
            var dbResult = await this.drivetrainRepo.GetDrivetrainByIdAsync(id);
            return new Drivetrain
            {
                Code = dbResult.Code,
                Description = dbResult.Description,
                Id = dbResult.Id,
            };
        }
    }
}
