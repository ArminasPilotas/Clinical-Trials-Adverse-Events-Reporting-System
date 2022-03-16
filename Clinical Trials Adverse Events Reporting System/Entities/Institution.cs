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
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Institution Type must be chosen")]
        public InstitutionType InstitutionType { get; set; }

        [Required]
        public Country Country { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Address must be at least 5 characters")]
        public string Address { get; set; }

        [Required]
        [Phone(ErrorMessage = "Phone number is not valid")]
        public string Phone { get; set; }


        [Phone(ErrorMessage = "Fax is not valid")]
        public string Fax { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string Email { get; set; }

        public string AlternateAddress { get; set; }
        public string AlternatePhone { get; set; }
        public string AlternateEmail { get; set; }
        public string AlternateFax { get; set; }


        [Required]
        [MinLength(1, ErrorMessage = "City name must be at least 1 character")]
        public string City { get; set; }

        public string RegNo { get; set; }

        public string StudyNumber { get; set; }

        public string Editor { get; set; }
        public string Author { get; set; }

        [Required]
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [MinLength(5, ErrorMessage = "Modify reason must be at least 5 characters")]
        public string ModifyReason { get; set; }


    }
}
