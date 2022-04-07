using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    public class AuthorityValidator : IValidator<Authority>
    {
        private readonly CTAERS _dbContext;

        public AuthorityValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Validate(Authority authority)
        {
            bool condition = _dbContext.Authorities
                .Where(c => c.Institution == authority.Institution &&
                c.InstitutionType == authority.InstitutionType &&
                c.InvestigationalProductType == authority.InvestigationalProductType)
                .Any();

            return !condition;
        }
    }
}
