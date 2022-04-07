using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    public class CountryRequirementVersionValidator : IValidator<CountryRequirementVersion>
    {
        private readonly CTAERS _dbContext;

        public CountryRequirementVersionValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Validate(CountryRequirementVersion countryRequirementVersion)
        {
            bool condition = _dbContext.CountryRequirementVersions
                .Where(c => c.InvestigationalProductType == countryRequirementVersion.InvestigationalProductType &&
                c.ContactVersion == countryRequirementVersion.ContactVersion &&
                c.RequirementVersion == countryRequirementVersion.RequirementVersion)
                .Any();

            return !condition;
        }
    }
}
