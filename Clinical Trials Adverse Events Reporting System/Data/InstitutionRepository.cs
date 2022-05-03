using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// Institution repository is the main logic for access data from the database
    /// </summary>
    public class InstitutionRepository : IInstitutionRepository
    {
        private readonly AppDbContext _dbContext;
        private IDbContextTransaction transaction;

        public InstitutionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method adds institution object to the database
        /// </summary>
        /// <param name="institution"></param>
        /// <returns></returns>
        public async Task Create(Institution institution)
        {
            institution.Created = DateTime.UtcNow;
            await _dbContext.AddAsync(institution);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Method deletes institution from the database
        /// </summary>
        /// <param name="institution"></param>
        /// <returns></returns>
        public async Task Delete(Institution institution)
        {
            try
            {
                transaction = await this._dbContext.Database.BeginTransactionAsync();

                _dbContext.Remove(institution);

                await this.transaction.CommitAsync();
                await this.transaction.DisposeAsync();
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                await this.transaction.RollbackAsync();
                await this.transaction.DisposeAsync();
            }
        }

        /// <summary>
        /// Method gets all institution by it's country name
        /// </summary>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public async Task<List<Institution>> GetByCountry(string countryName)
        {
            return await _dbContext.Institutions
                .Include(e => e.InstitutionType)
                .Include(e=>e.Country)
                .Where(e => e.Country.Name == countryName).ToListAsync();
        }

        /// <summary>
        /// Method gets institution from the database base by it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Institution> GetById(int id)
        {
            return await _dbContext.Institutions
                .Include(e => e.InstitutionType)
                .Include(e => e.Country)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        /// <summary>
        /// Method updates institution object in the database
        /// </summary>
        /// <param name="institution"></param>
        /// <returns></returns>
        public async Task Update (Institution institution)
        {
            institution.Modified = DateTime.UtcNow;
            _dbContext.Institutions.Update(institution);
            await _dbContext.SaveChangesAsync();
        }
    }
}
