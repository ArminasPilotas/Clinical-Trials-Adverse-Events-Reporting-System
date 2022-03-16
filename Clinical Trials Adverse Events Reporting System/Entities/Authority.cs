using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class Authority
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Country Country { get; set; }
        [Required(ErrorMessage = "Investigational Product Type must be chosen")]
        public InvestigationalProductType InvestigationalProductType { get; set; }
        [Required(ErrorMessage = "Institution Type must be chosen")]
        public InstitutionType InstitutionType { get; set; }
        [Required(ErrorMessage = "Institution must be chosen")]
        public Institution Institution { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
