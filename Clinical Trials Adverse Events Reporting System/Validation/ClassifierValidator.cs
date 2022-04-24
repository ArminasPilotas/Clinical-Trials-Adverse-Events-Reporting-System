using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    /// <summary>
    /// Class helps to validate user input on classifiers forms
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class ClassifierValidator<TEntity> : IValidator<TEntity>
        where TEntity : Classifier
    {
        private readonly CTAERS _dbContext;

        public ClassifierValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method helps to validate classifiers inputs
        /// returns true if no classifier name is found in the database, otherwise false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Validate(TEntity entity)
        {
            return !_dbContext.Set<TEntity>()
                .Where(c => c.Name == entity.Name &&
                c.Id != entity.Id)
                .Any();
        }
    }
}
