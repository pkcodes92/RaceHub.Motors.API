// <copyright file="ManufacturerService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the methods in the <see cref="IManufacturerService"/>.
    /// </summary>
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository manufacturerRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManufacturerService"/> class.
        /// </summary>
        /// <param name="manufacturerRepo">The manufacturer repository injection.</param>
        public ManufacturerService(IManufacturerRepository manufacturerRepo)
        {
            this.manufacturerRepo = manufacturerRepo;
        }

        /// <summary>
        /// This method will get all the manufacturers from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Manufacturer"/>.</returns>
        public async Task<List<Manufacturer>> GetAllManufacturersAsync()
        {
            var dbResults = await this.manufacturerRepo.GetAllManufacturersAsync();
            var results = new List<Manufacturer>();

            foreach (var manufacturer in dbResults)
            {
                var manufacturerToAdd = new Manufacturer
                {
                    Id = manufacturer.Id,
                    CountryCode = manufacturer.CountryCode,
                    Region = manufacturer.Region,
                    Flag = manufacturer.ManufacturerNationFlag,
                    Logo = manufacturer.ManufacturerLogo,
                    Country = manufacturer.Country,
                    Name = manufacturer.Name,
                };

                results.Add(manufacturerToAdd);
            }

            return results;
        }
    }
}
