using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class CountryRequirementVersion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Country Country { get; set; }
        [Required]
        public DateTime DateOfRenewal { get; set; }
        public string RequirementVersion { get; set; }
        [Required]
        public DateTime ContactRevisionDate { get; set; }
        public string ContactVersion { get; set; }
        [Required]
        public InvestigationalProductType InvestigationalProductType { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifyReason { get; set; }
    }
}
