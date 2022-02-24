using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class Institution
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public InstitutionType InstitutionType { get; set; }

        [Required]
        public Country Country { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public string AlternateAddress { get; set; }
        public string AlternatePhone { get; set; }
        public string AlternateEmail { get; set; }
        public string AlternateFax { get; set; }

        public string City { get; set; }
        public string RegNo { get; set; }
        public string StudyNumber { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifyReason { get; set; }


    }
}
