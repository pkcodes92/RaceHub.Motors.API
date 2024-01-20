// <copyright file="ManufacturerService.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API.Services
{
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.DTO;
    using RaceHub.Motors.API.DTO.Models;
    using RaceHub.Motors.API.DTO.Request;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class implements the methods in the <see cref="IManufacturerService"/>.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ManufacturerService"/> class.
    /// </remarks>
    /// <param name="manufacturerRepo">The manufacturer repository injection.</param>
    public class ManufacturerService(IManufacturerRepository manufacturerRepo)
        : IManufacturerService
    {
        private readonly IManufacturerRepository manufacturerRepo = manufacturerRepo;

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
        /// This method will get all of the manufacturing countries.
        /// </summary>
        /// <returns>A unit of execution that contains a list of type <see cref="Country"/>.</returns>
        public async Task<List<Country>> GetAllManufacturerCountriesAsync()
        {
            var dbResults = await this.manufacturerRepo.GetAllManufacturersAsync();
            var distinctResults = dbResults.DistinctBy(g => g.Country).ToList();

            var results = new List<Country>();
            foreach (var country in distinctResults)
            {
                var itemToAdd = new Country
                {
                    CountryCode = country.CountryCode,
                    Region = country.Region,
                    Flag = country.ManufacturerNationFlag,
                    Name = country.Country,
                };

                results.Add(itemToAdd);
            }

            return results;
        }

        /// <summary>
        /// This method will get a single country by the country code.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <returns>A unit of execution that contains a type of <see cref="Country"/>.</returns>
        public async Task<Country> GetCountryByCodeAsync(string countryCode)
        {
            var dbResults = await this.manufacturerRepo.GetAllManufacturersAsync();
            var distinctResults = dbResults.DistinctBy(g => g.Country).ToList();

            var result = distinctResults.FirstOrDefault(g => g.CountryCode == countryCode);

            return new Country
            {
                CountryCode = result?.CountryCode,
                Region = result?.Region,
                Flag = result?.ManufacturerNationFlag,
                Name = result?.Country,
            };
        }

        /// <summary>
        /// This method will get all of the manufacturers that exist in a single country.
        /// </summary>
        /// <param name="countryCode">The country code to search.</param>
        /// <returns>A unit of execution that contains a list of type <see cref="Manufacturer"/>.</returns>
        public async Task<List<Manufacturer>> GetManufacturersByCountryCodeAsync(string countryCode)
        {
            var dbResults = await this.manufacturerRepo.GetManufacturersByCountryCodeAsync(countryCode);
            var results = new List<Manufacturer>();

            foreach (var item in dbResults)
            {
                var manufacturer = new Manufacturer
                {
                    Id = item.Id,
                    CountryCode = item.CountryCode,
                    Region = item.Region,
                    Flag = item.ManufacturerNationFlag,
                    Logo = item.ManufacturerLogo,
                    Country = item.Country,
                    Name = item.Name,
                };

                results.Add(manufacturer);
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
