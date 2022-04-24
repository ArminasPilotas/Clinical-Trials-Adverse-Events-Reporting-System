using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    /// <summary>
    /// Class helps to validate user input on country requirement version forms
    /// </summary>
    public class CountryRequirementVersionValidator : IValidator<CountryRequirementVersion>
    {
        private readonly CTAERS _dbContext;

        public CountryRequirementVersionValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method helps to validate country requirement version inputs
        /// returns true if no investigational product type, contact version, requirement version is found in the database, otherwise false
        /// </summary>
        /// <param name="countryRequirementVersion"></param>
        /// <returns></returns>
        public bool Validate(CountryRequirementVersion countryRequirementVersion)
        {
            bool condition = _dbContext.CountryRequirementVersions
                .Where(c => c.InvestigationalProductType == countryRequirementVersion.InvestigationalProductType &&
                c.ContactVersion == countryRequirementVersion.ContactVersion &&
                c.RequirementVersion == countryRequirementVersion.RequirementVersion &&
                c.Id != countryRequirementVersion.Id)
                .Any();

            return !condition;
        }
    }
}
