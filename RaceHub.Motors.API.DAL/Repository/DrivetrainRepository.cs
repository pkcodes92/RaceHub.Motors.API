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

        public async Task<List<Drivetrain>> GetAllDrivetrainsAsync()
        {
            var results = await this.context.Drivetrains.ToListAsync();
            return results!;
        }

        public async Task<Drivetrain> GetDrivetrainByIdAsync(int id)
        {
            var result = await this.context.Drivetrains.FirstOrDefaultAsync(g => g.Id == id);
            return result!;
        }
    }
}
