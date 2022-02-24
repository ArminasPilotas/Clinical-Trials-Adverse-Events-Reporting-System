using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class NationalRequirement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Country Country { get; set; }
        [Required]
        public ReportingType ReportingType { get; set; }
        [Required]
        public InstitutionType InstitutionType { get; set; }
        public SusarType SusarType { get; set; }
        [Required]
        public CaseOrigin CaseOrigin { get; set; }
        [Required]
        public InvestigationalProductType InvestigationalProductType { get; set; }
        [Required]
        public ReportType ReportType { get; set; }
        public int Days { get; set; }
        public string Comments { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifyReason { get; set; }


    }
}
