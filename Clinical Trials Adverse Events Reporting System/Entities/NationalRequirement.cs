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

        [Required(ErrorMessage = "Reporting Type must be chosen")]
        public ReportingType ReportingType { get; set; }

        [Required(ErrorMessage = "Institution Type must be chosen")]
        public InstitutionType InstitutionType { get; set; }

        [Required(ErrorMessage = "Susar Type must be chosen")]
        public SusarType SusarType { get; set; }

        [Required(ErrorMessage = "Case Origin must be chosen")]
        public CaseOrigin CaseOrigin { get; set; }

        [Required(ErrorMessage = "Investigational Product Type must be chosen")]
        public InvestigationalProductType InvestigationalProductType { get; set; }

        [Required(ErrorMessage = "Report Type must be chosen")]
        public ReportType ReportType { get; set; }

        public int Days { get; set; }
        public string Comments { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }

        [Required]
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [MinLength(5, ErrorMessage = "Modify reason must be at least 5 characters")]
        public string ModifyReason { get; set; }

        public bool Valid { get; set; } = true;
    }
}
