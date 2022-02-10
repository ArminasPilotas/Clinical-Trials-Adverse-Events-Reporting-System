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
    }

}
