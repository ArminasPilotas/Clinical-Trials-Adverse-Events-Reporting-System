﻿// <auto-generated />
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    [DbContext(typeof(CTAERS))]
    partial class CTAERSModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Classifier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CaseOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstitutionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestigationalProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportingMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SusarType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classifiers");
                });
#pragma warning restore 612, 618
        }
    }
}
