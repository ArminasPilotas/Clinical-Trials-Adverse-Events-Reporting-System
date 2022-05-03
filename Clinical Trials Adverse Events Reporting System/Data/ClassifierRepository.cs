using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// Generic classifier repository, class helps for access data from the database
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class ClassifierRepository<TEntity> : IClassifierRepository<TEntity>
        where TEntity : Classifier
    {
        private readonly AppDbContext _dbContext;

        public ClassifierRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Method adds classifier object to the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Create(TEntity entity)
        {
            entity.Created = DateTime.UtcNow;
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Method helps to delete classifier from the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void DeleteUnitOfWork(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// Gets all classifiers based by TEntity from the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }
        /// <summary>
        /// Method help to get classifier from the database based by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public AppDbContext GetDbContext()
        {
            return _dbContext;
        }

        /// <summary>
        /// Method updates classifier object in the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Update(TEntity entity)
        {
            entity.Modified = DateTime.UtcNow;
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

    }
}
