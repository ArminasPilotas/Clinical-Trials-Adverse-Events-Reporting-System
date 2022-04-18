using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class NationalRequirementsRepository : INationalRequirementsRepository
    {
        private readonly CTAERS _dbContext;

        public NationalRequirementsRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(NationalRequirement nationalRequirement)
        {
            nationalRequirement.Created = DateTime.UtcNow;
            await _dbContext.AddAsync(nationalRequirement);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(NationalRequirement nationalRequirement)
        {
            _dbContext.Remove(nationalRequirement);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<NationalRequirement>> GetByCountry(string countryName)
        {
            return await _dbContext.NationalRequirements
                .Include(e => e.InstitutionType)
                .Include(e => e.InvestigationalProductType)
                .Include(e => e.ReportingType)
                .Include(e => e.ReportType)
                .Include(e => e.Country)
                .Include(e => e.CaseOrigin)
                .Include(e => e.SusarType)
                .Where(e => e.Country.Name == countryName).ToListAsync();
        }

        public async Task<NationalRequirement> GetById(int id)
        {
            return await _dbContext.NationalRequirements
                .Include(e => e.InstitutionType)
                .Include(e => e.InvestigationalProductType)
                .Include(e => e.ReportingType)
                .Include(e => e.ReportType)
                .Include(e => e.Country)
                .Include(e => e.CaseOrigin)
                .Include(e => e.SusarType)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update(NationalRequirement nationalRequirement)
        {
            nationalRequirement.Modified = DateTime.UtcNow;
            _dbContext.NationalRequirements.Update(nationalRequirement);
            await _dbContext.SaveChangesAsync();
        }
    }
}
