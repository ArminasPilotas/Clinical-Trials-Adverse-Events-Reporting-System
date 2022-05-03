using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// Country repository is only used to get countries from the database
    /// </summary>
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _dbContext;

        public CountryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Gets all countries from the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<Country>> GetAll()
        {
            return await _dbContext.Countries.ToListAsync();
        }
        /// <summary>
        /// Gets country based by country parameter Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Country> GetById(int id)
        {
            return await _dbContext.Countries.FirstOrDefaultAsync(e => e.Id == id);
        }
        /// <summary>
        /// Gets country by it's name from the database
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<Country> GetByName(string Name)
        {
            return await _dbContext.Countries.FirstOrDefaultAsync(e => e.Name == Name);
        }
    }
}
