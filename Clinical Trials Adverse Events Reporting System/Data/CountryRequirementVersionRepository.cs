using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// Main logic for access data from the database
    /// </summary>
    public class CountryRequirementVersionRepository : ICountryRequirementVersionRepository
    {
        private readonly AppDbContext _dbContext;

        public CountryRequirementVersionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method adds country requirement version object to the database
        /// </summary>
        /// <param name="countryRequirementVersion"></param>
        /// <returns></returns>
        public async Task Create (CountryRequirementVersion countryRequirementVersion)
        {
            countryRequirementVersion.Created = DateTime.UtcNow;
            await _dbContext.AddAsync(countryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Method deletes country requirement version object from the database
        /// </summary>
        /// <param name="countryRequirementVersion"></param>
        /// <returns></returns>
        public async Task Delete(CountryRequirementVersion countryRequirementVersion)
        {
            _dbContext.Remove(countryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Method updates country requirement version object in the database
        /// </summary>
        /// <param name="countryRequirementVersion"></param>
        /// <returns></returns>
        public async Task Update (CountryRequirementVersion countryRequirementVersion)
        {
            countryRequirementVersion.Modified = DateTime.UtcNow;
            _dbContext.CountryRequirementVersions.Update(countryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }
       
        /// <summary>
        /// Gets country requirement version by it's Id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CountryRequirementVersion> GetById(int id)
        {
            return await _dbContext.CountryRequirementVersions
                .Include(e => e.Country)
                .Include(e => e.InvestigationalProductType)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        /// <summary>
        /// Gets all country requirement versions by it's country name
        /// </summary>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public async Task<List<CountryRequirementVersion>> GetByCountry(string countryName)
        {
            return await _dbContext.CountryRequirementVersions
                .Include(e => e.Country)
                .Include(e => e.InvestigationalProductType)
                .Where(e => e.Country.Name == countryName).ToListAsync();
        }

        /// <summary>
        /// Gets all country requirement versions by it's investigational product type classifier Id
        /// </summary>
        /// <param name="IPTypeId"></param>
        /// <returns></returns>
        public async Task<List<CountryRequirementVersion>> GetByIPType(int IPTypeId)
        {
            return await _dbContext.CountryRequirementVersions
                .Include(e => e.Country)
                .Include(e => e.InvestigationalProductType)
                .Where(e => e.InvestigationalProductType.Id == IPTypeId).ToListAsync();
        }
    }
}
