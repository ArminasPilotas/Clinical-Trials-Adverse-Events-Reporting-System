﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class NationalRequirementVersionRepository
    {
        private readonly CTAERS _dbContext;

        public NationalRequirementVersionRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(NationalRequirementVersion nationalRequirementCountryRequirementVersion)
        {
            await _dbContext.AddAsync(nationalRequirementCountryRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task<NationalRequirementVersion> GetByNationalRequirement(int nationalRequirementId) //TODO implement in nationalRequirements List
        {
            return await _dbContext.NationalRequirementCountryRequirementVersions.FirstOrDefaultAsync(e => e.NationalRequirement.Id == nationalRequirementId);
        }

        public async Task<List<NationalRequirementVersion>> GetAll()
        {
            return await _dbContext.NationalRequirementCountryRequirementVersions
                .Include(e => e.CountryRequirementVersion)
                .Include(e => e.CountryRequirementVersion.InvestigationalProductType)
                .Include(e => e.NationalRequirement)
                .ToListAsync();
        }
        
        public async Task Update(NationalRequirementVersion nationalRequirementVersion)
        {
            _dbContext.NationalRequirementCountryRequirementVersions.Update(nationalRequirementVersion);
            await _dbContext.SaveChangesAsync();
        }

    }
}
