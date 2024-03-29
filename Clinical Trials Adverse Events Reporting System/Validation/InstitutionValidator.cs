﻿using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    /// <summary>
    /// Class helps to validate user input on institution forms
    /// </summary>
    public class InstitutionValidator : IValidator<Institution>
    {
        private readonly CTAERS _dbContext;

        public InstitutionValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method helps to validate institution inputs
        /// returns true if no institution name is found in the database, otherwise false
        /// </summary>
        /// <param name="institution"></param>
        /// <returns></returns>
        public bool Validate(Institution institution)
        {
            bool condition = _dbContext.Institutions
                .Where(c => c.Name == institution.Name &&
                c.Id != institution.Id)
                .Any();

            return !condition;
        }
    }
}
