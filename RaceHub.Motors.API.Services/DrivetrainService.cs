// <copyright file="DrivetrainService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// Initializes a new instance of the <see cref="DrivetrainService"/> class.
    /// </summary>
    /// <param name="drivetrainRepo">The drivetrain repository injection.</param>
    public class DrivetrainService(IDrivetrainRepository drivetrainRepo)
        : IDrivetrainService
    {
        private readonly IDrivetrainRepository drivetrainRepo = drivetrainRepo;

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

        /// <summary>
        /// This method implementation adds a new drivetrain to the database.
        /// </summary>
        /// <param name="request">The new drivetrain information to add.</param>
        /// <returns>A unit of execution that contains the type of <see cref="Drivetrain"/>.</returns>
        public async Task<Drivetrain> AddDrivetrainAsync(AddDrivetrainRequest request)
        {
            var drivetrainEntityToAdd = new DAL.Entity.Drivetrain
            {
                Code = request.Code,
                Description = request.Description,
                Created = DateTime.Now,
                CreatedBy = "RaceHub-Motors-API",
                LastUpd = DateTime.Now,
                LastUpdBy = "RaceHub-Motors-API",
                LastUpdApp = "RaceHub-Motors-API",
            };

            var dbResult = await this.drivetrainRepo.AddDrivetrainAsync(drivetrainEntityToAdd);

            return new Drivetrain
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method implementation updates an existing drivetrain in the database.
        /// </summary>
        /// <param name="request">The necessary information containing the updated drivetrain.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        public async Task<Drivetrain> UpdateDrivetrainAsync(UpdateDrivetrainRequest request)
        {
            var drivetrainEntityToUpdate = new DAL.Entity.Drivetrain
            {
                Id = request.Id,
                Code = request.Code,
                Description = request.Description,
                LastUpd = DateTime.Now,
                LastUpdApp = "RaceHub-Motors-API",
                LastUpdBy = "RaceHub-Motors-API",
            };

            var dbResult = await this.drivetrainRepo.UpdateDrivetrainAsync(drivetrainEntityToUpdate);

            return new Drivetrain
            {
                Id = dbResult.Id,
                Code = dbResult.Code,
                Description = dbResult.Description,
            };
        }

        /// <summary>
        /// This method implementation removes a drivetrain from the database.
        /// </summary>
        /// <param name="id">The primary key of the drivetrain entity.</param>
        /// <returns>A unit of execution that contains a boolean indicating successful deletion.</returns>
        public async Task<bool> DeleteDrivetrainAsync(int id)
        {
            var result = await this.drivetrainRepo.DeleteDrivetrainAsync(id);
            return result;
        }
    }
}
