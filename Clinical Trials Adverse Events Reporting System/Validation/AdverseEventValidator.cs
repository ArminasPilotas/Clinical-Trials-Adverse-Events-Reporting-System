using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    public class AdverseEventValidator : IValidator<AdverseEvent>
    {
        private readonly CTAERS _dbContext;

        public AdverseEventValidator(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Validate(AdverseEvent adverseEvent)
        {
            bool condition = _dbContext.AdverseEvents
                .Where(c => c.StudyNo == adverseEvent.StudyNo &&
                c.OccurredOn == adverseEvent.OccurredOn &&
                c.InvestigationalProductType.Id == adverseEvent.InvestigationalProductType.Id &&
                c.Id != adverseEvent.Id)
                .Any();

            return !condition;
        }
    }
}
