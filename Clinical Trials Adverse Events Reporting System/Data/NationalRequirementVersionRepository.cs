using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// National Requirement version repository is the main logic for access data from the database
    /// </summary>
    public class NationalRequirementVersionRepository : INationalRequirementVersionRepository
    {
        private readonly CTAERS _dbContext;

        public NationalRequirementVersionRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method adds national requirement version object to the database
        /// </summary>
        /// <param name="nationalRequirementCountryRequirementVersion"></param>
        /// <returns></returns>
        public async Task Create(NationalRequirementVersion nationalRequirementCountryRequirementVersion)
        {
            nationalRequirementCountryRequirementVersion.Created = DateTime.UtcNow;
            await _dbContext.AddAsync(nationalRequirementCountryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }
        
        /// <summary>
        /// Gets national requirement version base by it's parameter national requirement Id
        /// </summary>
        /// <param name="nationalRequirementId"></param>
        /// <returns></returns>
        public async Task<NationalRequirementVersion> GetByNationalRequirement(int nationalRequirementId)
        {
            return await _dbContext.NationalRequirementCountryRequirementVersions.FirstOrDefaultAsync(e => e.NationalRequirement.Id == nationalRequirementId);
        }

        /// <summary>
        /// Gets all national requirement versions objects from the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<NationalRequirementVersion>> GetAll()
        {
            return await _dbContext.NationalRequirementCountryRequirementVersions
                .Include(e => e.CountryRequirementVersion)
                .Include(e => e.CountryRequirementVersion.InvestigationalProductType)
                .Include(e => e.NationalRequirement)
                .ToListAsync();
        }
        
        /// <summary>
        /// Method updates national requirement version to the database
        /// </summary>
        /// <param name="nationalRequirementVersion"></param>
        /// <returns></returns>
        public async Task Update(NationalRequirementVersion nationalRequirementVersion)
        {
            nationalRequirementVersion.Modified = DateTime.UtcNow;
            _dbContext.NationalRequirementCountryRequirementVersions.Update(nationalRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }

    }
}
