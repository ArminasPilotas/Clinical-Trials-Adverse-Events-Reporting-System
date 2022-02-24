using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class InstitutionRepository
    {
        private readonly CTAERS _dbContext;

        public InstitutionRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Institution institution)
        {
            await _dbContext.AddAsync(institution);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Institution institution)
        {
            _dbContext.Remove(institution);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Institution>> GetByCountry(string countryName) //TODO is this good aproach? I can Find by id or by object
        {
            return await _dbContext.Institutions
                .Include(e => e.InstitutionType)
                .Include(e=>e.Country)
                .Where(e => e.Country.Name == countryName).ToListAsync();
            //Explixit loading
        }

        public async Task<Institution> GetById(int id)
        {
            return await _dbContext.Institutions
                .Include(e => e.InstitutionType)
                .Include(e => e.Country)
                .FirstOrDefaultAsync(e => e.Id == id);
            //Explixit loading
        }

        public async Task Update (Institution institution)
        {
            _dbContext.Institutions.Update(institution);
            await _dbContext.SaveChangesAsync();
        }
    }
}
