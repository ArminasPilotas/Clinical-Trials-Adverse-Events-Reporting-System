using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    public class InstitutionValidator : IValidator<Institution>
    {
        private readonly CTAERS _dbContext;

        public InstitutionValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Validate(Institution institution)
        {
            bool condition = _dbContext.Institutions
                .Where(c => c.Name == institution.Name)
                .Any();

            return !condition;
        }
    }
}
