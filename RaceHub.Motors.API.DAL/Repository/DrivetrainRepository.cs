// <copyright file="DrivetrainRepository.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.DAL.Repository
{
    using Microsoft.EntityFrameworkCore;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Entity;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;

    /// <summary>
    /// This class implements the methods defined in <see cref="IDrivetrainRepository"/>.
    /// </summary>
    public class DrivetrainRepository : IDrivetrainRepository
    {
        private readonly RaceHubMotorsContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrivetrainRepository"/> class.
        /// </summary>
        /// <param name="context">The database context injection.</param>
        public DrivetrainRepository(RaceHubMotorsContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// This method gets all of the drivetrains from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Drivetrain"/>.</returns>
        public async Task<List<Drivetrain>> GetAllDrivetrainsAsync()
        {
            var results = await this.context.Drivetrains.ToListAsync();
            return results!;
        }

        /// <summary>
        /// This method gets a single drivetrain by the primary key.
        /// </summary>
        /// <param name="id">The primary key of the drivetrain entity.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        public async Task<Drivetrain> GetDrivetrainByIdAsync(int id)
        {
            var result = await this.context.Drivetrains.FirstOrDefaultAsync(g => g.Id == id);
            return result!;
        }

        /// <summary>
        /// This method will add a new drivetrain to the database.
        /// </summary>
        /// <param name="drivetrain">The new drivetrain information to be added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        public async Task<Drivetrain> AddDrivetrainAsync(Drivetrain drivetrain)
        {
            this.context.Drivetrains.Add(drivetrain);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? drivetrain : null!;
        }

        /// <summary>
        /// This method implementation will update a drivetrain in the database.
        /// </summary>
        /// <param name="drivetrain">The updated drivetrain in the database.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
        public async Task<Drivetrain> UpdateDrivetrainAsync(Drivetrain drivetrain)
        {
            this.context.ChangeTracker.Clear();
            this.context.Drivetrains.Update(drivetrain);
            var result = await this.context.SaveChangesAsync();
            return result > 0 ? drivetrain : null!;
        }

        /// <summary>
        /// This method implementation will remove a drivetrain from the database.
        /// </summary>
        /// <param name="id">The primary key of the drivetrain entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        public async Task<bool> DeleteDrivetrainAsync(int id)
        {
            var drivetrainToDelete = await this.context.Drivetrains.FirstOrDefaultAsync(g => g.Id == id);
            this.context.Drivetrains.Remove(drivetrainToDelete!);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }
    }
}
