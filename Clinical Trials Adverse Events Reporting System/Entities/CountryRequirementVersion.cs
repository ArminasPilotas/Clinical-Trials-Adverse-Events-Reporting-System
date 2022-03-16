using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Utilities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class CountryRequirementVersion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Country Country { get; set; }

        [Required (ErrorMessage = "Date of renewal can't be empty")]
        [Date(ErrorMessage = "Date of renewal is not in required range")]
        public DateTime DateOfRenewal { get; set; }

        [Required (ErrorMessage ="Please enter the requirement version")]
        [MinLength (3, ErrorMessage = "Requirement Version should be at least 3 characters")]
        public string RequirementVersion { get; set; }

        [Required(ErrorMessage = "Contact revision date can't be empty")]
        [Date(ErrorMessage = "Contact revision date is not in required range")]
        public DateTime ContactRevisionDate { get; set; }

        [Required (ErrorMessage = "Please enter the contact version")]
        [MinLength(3, ErrorMessage = "Contact Version should be at least 3 characters")]
        public string ContactVersion { get; set; }
        
        [Required(ErrorMessage = "Investigation product type should be choosen")]
        public InvestigationalProductType InvestigationalProductType { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }

        [Required]
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [MinLength(5, ErrorMessage = "Modify reason must be at least 5 characters")]
        public string ModifyReason { get; set; }
    }
}
