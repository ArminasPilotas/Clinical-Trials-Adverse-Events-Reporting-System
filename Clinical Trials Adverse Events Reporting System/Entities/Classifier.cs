using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public abstract class Classifier //Table per Concrete Type (TPC), migration4
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Editor { get; set; }
        public string Author { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifyReason { get; set; }
    }

    public class ReportingType : Classifier
    {
    }

    public class ReportType : Classifier
    {
    }

    public class ReportingMethod : Classifier
    {
    }

    public class InstitutionType : Classifier
    {
    }

    public class SusarType : Classifier
    {
    }

    public class CaseOrigin : Classifier
    {
    }

    public class InvestigationalProductType : Classifier
    {
    }

}
