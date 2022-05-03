using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// National requirement repository is the main logic for access data from the database
    /// </summary>
    public class NationalRequirementsRepository : INationalRequirementsRepository
    {
        private readonly AppDbContext _dbContext;

        public NationalRequirementsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method adds national requirement object to the database
        /// </summary>
        /// <param name="nationalRequirement"></param>
        /// <returns></returns>
        public async Task Create(NationalRequirement nationalRequirement)
        {
            nationalRequirement.Created = DateTime.UtcNow;
            await _dbContext.AddAsync(nationalRequirement);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Method helps to delete national requirement from the database
        /// </summary>
        /// <param name="nationalRequirement"></param>
        /// <returns></returns>
        public async Task Delete(NationalRequirement nationalRequirement)
        {
            _dbContext.Remove(nationalRequirement);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all national requirement objects from the database based by country name
        /// </summary>
        /// <param name="countryName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets national requirement object from the database based by it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method helps to update national requirement object in the database
        /// </summary>
        /// <param name="nationalRequirement"></param>
        /// <returns></returns>
        public async Task Update(NationalRequirement nationalRequirement)
        {
            nationalRequirement.Modified = DateTime.UtcNow;
            _dbContext.NationalRequirements.Update(nationalRequirement);
            await _dbContext.SaveChangesAsync();
        }
    }
}
