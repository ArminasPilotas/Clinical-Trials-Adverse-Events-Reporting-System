using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    public class ClassifierValidator<TEntity> : IValidator<TEntity>
        where TEntity : Classifier
    {
        private readonly CTAERS _dbContext;

        public ClassifierValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Validate(TEntity entity)
        {
            return !_dbContext.Set<TEntity>()
                .Where(c => c.Name == entity.Name &&
                c.Id != entity.Id)
                .Any();
        }
    }
}
