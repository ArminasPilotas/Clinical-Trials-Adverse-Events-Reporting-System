using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class ReportedInstitution
    {
        public int Id { get; set; }

        public AdverseEvent AdverseEvent { get; set; }

        public Institution Institution { get; set; }

        public DateTime ReportBy { get; set; }

        public DateTime ReportedOn { get; set; }
    }
}
