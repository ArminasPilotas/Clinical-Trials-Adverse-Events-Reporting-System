using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class CTAERS : DbContext  //AppdbContext
    {

        public CTAERS()
        {

        }

        public CTAERS(DbContextOptions<CTAERS> options)
            : base(options)
        {
        }

        public virtual DbSet<ReportingType> ReportingTypes { get; set; }
        public virtual DbSet<ReportType> ReportTypes { get; set; }
        public virtual DbSet<ReportingMethod> ReportingMethods { get; set; }
        public virtual DbSet<InstitutionType> InstitutionTypes { get; set; }
        public virtual DbSet<SusarType> SusarTypes { get; set; }
        public virtual DbSet<CaseOrigin> CaseOrigins { get; set; }
        public virtual DbSet<InvestigationalProductType> InvestigationalProductTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<NationalRequirement> NationalRequirements { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<CountryRequirementVersion> CountryRequirementVersions { get; set; }
        public virtual DbSet<NationalRequirementVersion> NationalRequirementCountryRequirementVersions { get; set; }
        public virtual DbSet<AdverseEvent> AdverseEvents { get; set; }
        public virtual DbSet<ReportedInstitution> ReportedInstitutions { get; set; }
    }

}
