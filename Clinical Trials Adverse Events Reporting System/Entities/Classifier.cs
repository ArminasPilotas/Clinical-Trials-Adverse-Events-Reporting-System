using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class Classifier
    {
        [Key]
        public int Id { get; set; }
        public string ReportingType { get; set; }
        public string ReportType { get; set; }
        public string ReportingMethod { get; set; }
        public string InstitutionType { get; set; }
        public string SusarType { get; set; }
        public string CaseOrigin { get; set; }
        public string InvestigationalProductType { get; set; }
    }
}
