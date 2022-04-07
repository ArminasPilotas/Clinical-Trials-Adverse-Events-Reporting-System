using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class AdverseEvent
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="Investigational Product Type must be chosen")]
        public InvestigationalProductType InvestigationalProductType { get; set; }

        public string StudyNo { get; set; }

        public string Description { get; set; }

        public DateTime OccurredOn { get; set; }

        public string AttachmentURL { get; set; }
    }
}
