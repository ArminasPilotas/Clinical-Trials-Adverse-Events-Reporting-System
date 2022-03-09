using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class CountryRequirementVersionRepository
    {
        private readonly CTAERS _dbContext;

        public CountryRequirementVersionRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create (CountryRequirementVersion countryRequirementVersion)
        {
            await _dbContext.AddAsync(countryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(CountryRequirementVersion countryRequirementVersion)
        {
            _dbContext.Remove(countryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update (CountryRequirementVersion countryRequirementVersion)
        {
            _dbContext.CountryRequirementVersions.Update(countryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task<CountryRequirementVersion> GetById(int id)
        {
            return await _dbContext.CountryRequirementVersions
                .Include(e => e.Country)
                .Include(e => e.InvestigationalProductType)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<CountryRequirementVersion>> GetByCountry(string countryName)
        {
            return await _dbContext.CountryRequirementVersions
                .Include(e => e.Country)
                .Include(e => e.InvestigationalProductType)
                .Where(e => e.Country.Name == countryName).ToListAsync();
        }

        public async Task<List<CountryRequirementVersion>> GetByIPType(int IPTypeId)
        {
            return await _dbContext.CountryRequirementVersions
                .Include(e => e.Country)
                .Include(e => e.InvestigationalProductType)
                .Where(e => e.InvestigationalProductType.Id == IPTypeId).ToListAsync();
        }
    }
}
