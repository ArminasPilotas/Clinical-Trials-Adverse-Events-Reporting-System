using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class CountryRepository : ICountryRepository
    {
        private readonly CTAERS _dbContext;

        public CountryRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Country>> GetAll()
        {
            return await _dbContext.Countries.ToListAsync();
        }

        public async Task<Country> GetById(int id)
        {
            return await _dbContext.Countries.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Country> GetByName(string Name)
        {
            return await _dbContext.Countries.FirstOrDefaultAsync(e => e.Name == Name);
        }
    }
}
