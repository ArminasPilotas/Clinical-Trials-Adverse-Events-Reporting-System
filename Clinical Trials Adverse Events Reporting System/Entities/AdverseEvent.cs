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

        [Required (ErrorMessage = "Study number can't be empty")]
        public string StudyNo { get; set; }
        
        [Required (ErrorMessage = "Description can't be empty")]
        [MinLength(20, ErrorMessage = "Desciption should be at least 20 characters long")]
        public string Description { get; set; }

        [Required (ErrorMessage = "Occurred On date must be chosen")]
        public DateTime OccurredOn { get; set; }

        public string AttachmentURL { get; set; }
    }
}
