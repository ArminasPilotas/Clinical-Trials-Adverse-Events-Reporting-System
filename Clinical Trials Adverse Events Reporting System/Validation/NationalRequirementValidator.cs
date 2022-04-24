using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    /// <summary>
    /// Class helps to validate user input on national requirement forms
    /// </summary>
    public class NationalRequirementValidator : IValidator<NationalRequirement>
    {
        private readonly CTAERS _dbContext;

        public NationalRequirementValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method helps to validate national requirement inputs
        /// returns true if no institution type, investigational product type, reporting type, report type, case origin is found in the database, otherwise false
        /// </summary>
        /// <param name="nationalRequirement"></param>
        /// <returns></returns>
        public bool Validate(NationalRequirement nationalRequirement)
        {
            bool condition = _dbContext.NationalRequirements
                .Where(c => c.InstitutionType == nationalRequirement.InstitutionType &&
                c.InvestigationalProductType == nationalRequirement.InvestigationalProductType &&
                c.ReportingType == nationalRequirement.ReportingType &&
                c.ReportType == nationalRequirement.ReportType &&
                c.CaseOrigin == nationalRequirement.CaseOrigin &&
                c.Id != nationalRequirement.Id)
                .Any();

            return !condition;
        }
    }
}
