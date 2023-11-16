// <copyright file="ManufacturerService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
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

        /// <summary>
        /// This method adds a new manufacturer to the database.
        /// </summary>
        /// <param name="request">The new information being added.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        public async Task<Manufacturer> AddManufacturerAsync(AddManufacturerRequest request)
        {
            var manufacturerEntityToAdd = new DAL.Entity.Manufacturer
            {
                Country = request.Country,
                Name = request.Name,
                CountryCode = request.CountryCode,
                Region = request.Region,
                Created = DateTime.Now,
                CreatedBy = "RaceHub-Motors-API",
                LastUpd = DateTime.Now,
                LastUpdApp = "RaceHub-Motors-API",
                LastUpdBy = "RaceHub-Motors-API",
                ManufacturerLogo = request.Logo,
                ManufacturerNationFlag = request.Flag,
            };

            var dbResult = await this.manufacturerRepo.AddManufacturerAsync(manufacturerEntityToAdd);

            return new Manufacturer
            {
                Id = dbResult.Id,
                CountryCode = dbResult.CountryCode,
                Region = dbResult.Region,
                Country = dbResult.Country,
                Flag = dbResult.ManufacturerNationFlag,
                Logo = dbResult.ManufacturerLogo,
                Name = dbResult.Name,
            };
        }

        /// <summary>
        /// This method will update a manufacturer in the database.
        /// </summary>
        /// <param name="request">The updated manufacturer information.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
        public async Task<Manufacturer> UpdateManufacturerAsync(UpdateManufacturerRequest request)
        {
            var manufacturerToUpdateEntity = new DAL.Entity.Manufacturer
            {
                Id = request.Id,
                CountryCode = request.CountryCode,
                Region = request.Region,
                Country = request.Country,
                Name = request.Name,
                ManufacturerLogo = request.Logo,
                ManufacturerNationFlag = request.Flag,
                LastUpd = DateTime.Now,
                LastUpdBy = "RaceHub-Motors-API",
                LastUpdApp = "RaceHub-Motors-API",
            };

            var dbResult = await this.manufacturerRepo.UpdateManufacturerAsync(manufacturerToUpdateEntity);

            return new Manufacturer
            {
                Id = dbResult.Id,
                CountryCode = dbResult.CountryCode,
                Region = dbResult.Region,
                Country = dbResult.Country,
                Flag = dbResult.ManufacturerNationFlag,
                Logo = dbResult.ManufacturerLogo,
                Name = dbResult.Name,
            };
        }

        /// <summary>
        /// This method will remove a manufacturer from the database.
        /// </summary>
        /// <param name="id">The primary key of the manufacturer entity.</param>
        /// <returns>A unit of execution that contains a boolean value indicating successful deletion.</returns>
        public async Task<bool> RemoveManufacturerAsync(int id)
        {
            var result = await this.manufacturerRepo.RemoveManufacturerAsync(id);
            return result;
        }
    }
}
