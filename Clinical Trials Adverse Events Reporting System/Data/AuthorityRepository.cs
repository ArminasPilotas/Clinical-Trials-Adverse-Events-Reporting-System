using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// Authority repository is the main logic for access data from the database
    /// </summary>
    public class AuthorityRepository : IAuthorityRepository
    {
        public readonly CTAERS _dbContext;

        public AuthorityRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Method adds authority object to the database
        /// </summary>
        /// <param name="authority"></param>
        /// <returns></returns>
        public async Task Create (Authority authority)
        {
            authority.Created = DateTime.UtcNow;
            await _dbContext.AddAsync(authority);
            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Method deletes authority from the database
        /// </summary>
        /// <param name="authority"></param>
        /// <returns></returns>
        public async Task Delete (Authority authority)
        {
            _dbContext.Remove(authority);
            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Gets list of authorities from the database based by country parameter in authorities
        /// </summary>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public async Task<List<Authority>> GetByCountry(string countryName)
        {
            return await _dbContext.Authorities
                .Include(e => e.Institution)
                .Include(e => e.InstitutionType)
                .Include(e => e.InvestigationalProductType)
                .Include(e => e.Country)
                .Where(e => e.Country.Name == countryName).ToListAsync();
        }
        /// <summary>
        /// Method helps to get authority from database based by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Authority> GetById(int id)
        {
            return await _dbContext.Authorities
                .Include(e => e.Institution)
                .Include(e => e.InstitutionType)
                .Include(e => e.InvestigationalProductType)
                .Include(e => e.Country)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
        /// <summary>
        /// Method updates authority object in the database
        /// </summary>
        /// <param name="authority"></param>
        /// <returns></returns>
        public async Task Update (Authority authority)
        {
            authority.Modified = DateTime.UtcNow;
            _dbContext.Authorities.Update(authority);
            await _dbContext.SaveChangesAsync();
        }
    }
}
