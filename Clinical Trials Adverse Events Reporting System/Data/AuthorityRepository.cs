using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class AuthorityRepository
    {
        public readonly CTAERS _dbContext;

        public AuthorityRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create (Authority authority)
        {
            await _dbContext.AddAsync(authority);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete (Authority authority)
        {
            _dbContext.Remove(authority);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Authority>> GetByCountry(string countryName)
        {
            return await _dbContext.Authorities
                .Include(e => e.Institution)
                .Include(e => e.InstitutionType)
                .Include(e => e.InvestigationalProductType)
                .Include(e => e.Country)
                .Where(e => e.Country.Name == countryName).ToListAsync();
        }

        public async Task<Authority> GetById(int id)
        {
            return await _dbContext.Authorities
                .Include(e => e.Institution)
                .Include(e => e.InstitutionType)
                .Include(e => e.InvestigationalProductType)
                .Include(e => e.Country)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update (Authority authority)
        {
            _dbContext.Authorities.Update(authority);
            await _dbContext.SaveChangesAsync();
        }
    }
}
