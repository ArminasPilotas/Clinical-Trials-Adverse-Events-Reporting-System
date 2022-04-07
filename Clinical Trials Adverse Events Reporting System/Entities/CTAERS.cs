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

        public DbSet<ReportingType> ReportingTypes { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<ReportingMethod> ReportingMethods { get; set; }
        public DbSet<InstitutionType> InstitutionTypes { get; set; }
        public DbSet<SusarType> SusarTypes { get; set; }
        public DbSet<CaseOrigin> CaseOrigins { get; set; }
        public DbSet<InvestigationalProductType> InvestigationalProductTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<NationalRequirement> NationalRequirements { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<CountryRequirementVersion> CountryRequirementVersions { get; set; }
        public DbSet<NationalRequirementVersion> NationalRequirementCountryRequirementVersions { get; set; }
        public DbSet<AdverseEvent> AdverseEvents { get; set; }
        public DbSet<ReportedInstitution> ReportedInstitutions { get; set; }
    }

}
