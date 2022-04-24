using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    /// <summary>
    /// Class helps to validate user input on authority forms
    /// </summary>
    public class AuthorityValidator : IValidator<Authority>
    {
        private readonly CTAERS _dbContext;

        public AuthorityValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method helps to validate authority inputs
        /// returns true if no institution, institution type, investigational product type is found in the database, otherwise false
        /// </summary>
        /// <param name="authority"></param>
        /// <returns></returns>
        public bool Validate(Authority authority)
        {
            bool condition = _dbContext.Authorities
                .Where(c => c.Institution == authority.Institution &&
                c.InstitutionType == authority.InstitutionType &&
                c.InvestigationalProductType == authority.InvestigationalProductType &&
                c.Id != authority.Id)
                .Any();

            return !condition;
        }
    }
}
