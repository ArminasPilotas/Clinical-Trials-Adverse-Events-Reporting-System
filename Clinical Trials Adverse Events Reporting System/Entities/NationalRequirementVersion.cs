using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class NationalRequirementVersion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public CountryRequirementVersion CountryRequirementVersion { get; set; }
        [Required]
        public NationalRequirement NationalRequirement { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifyReason { get; set; }
    }
}
