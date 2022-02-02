using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Clinical_Trials_Adverse_Events_Reporting_System.Entities
{
    public class CTAERS : DbContext
    {

        public CTAERS(DbContextOptions<CTAERS> options)
            : base(options)
        {
        }

        public DbSet<Classifier> Classifiers { get; set; }
    }
}
