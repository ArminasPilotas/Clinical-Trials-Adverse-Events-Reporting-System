﻿// <auto-generated />
using System;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    [DbContext(typeof(CTAERS))]
    [Migration("20220307070224_migration8")]
    partial class migration8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Authority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InstitutionId")
                        .HasColumnType("int");

                    b.Property<int?>("InstitutionTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("InvestigationalProductTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("InstitutionId");

                    b.HasIndex("InstitutionTypeId");

                    b.HasIndex("InvestigationalProductTypeId");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.CaseOrigin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CaseOrigins");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.CountryRequirementVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContactRevisionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRenewal")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvestigationalProductTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementVersion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("InvestigationalProductTypeId");

                    b.ToTable("CountryRequirementVersions");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternateAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternateFax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternatePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InstitutionTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("InstitutionTypeId");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InstitutionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InstitutionTypes");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InvestigationalProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InvestigationalProductTypes");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.NationalRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CaseOriginId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InstitutionTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("InvestigationalProductTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ReportingTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("SusarTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaseOriginId");

                    b.HasIndex("CountryId");

                    b.HasIndex("InstitutionTypeId");

                    b.HasIndex("InvestigationalProductTypeId");

                    b.HasIndex("ReportTypeId");

                    b.HasIndex("ReportingTypeId");

                    b.HasIndex("SusarTypeId");

                    b.ToTable("NationalRequirements");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.NationalRequirementCountryRequirementVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryRequirementVersionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalRequirementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryRequirementVersionId");

                    b.HasIndex("NationalRequirementId");

                    b.ToTable("NationalRequirementCountryRequirementVersions");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.ReportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReportTypes");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.ReportingMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReportingMethods");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.ReportingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReportingTypes");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.SusarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SusarTypes");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Authority", b =>
                {
                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Institution", "Institution")
                        .WithMany()
                        .HasForeignKey("InstitutionId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InstitutionType", "InstitutionType")
                        .WithMany()
                        .HasForeignKey("InstitutionTypeId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InvestigationalProductType", "InvestigationalProductType")
                        .WithMany()
                        .HasForeignKey("InvestigationalProductTypeId");

                    b.Navigation("Country");

                    b.Navigation("Institution");

                    b.Navigation("InstitutionType");

                    b.Navigation("InvestigationalProductType");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.CountryRequirementVersion", b =>
                {
                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InvestigationalProductType", "InvestigationalProductType")
                        .WithMany()
                        .HasForeignKey("InvestigationalProductTypeId");

                    b.Navigation("Country");

                    b.Navigation("InvestigationalProductType");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Institution", b =>
                {
                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InstitutionType", "InstitutionType")
                        .WithMany()
                        .HasForeignKey("InstitutionTypeId");

                    b.Navigation("Country");

                    b.Navigation("InstitutionType");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.NationalRequirement", b =>
                {
                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.CaseOrigin", "CaseOrigin")
                        .WithMany()
                        .HasForeignKey("CaseOriginId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InstitutionType", "InstitutionType")
                        .WithMany()
                        .HasForeignKey("InstitutionTypeId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.InvestigationalProductType", "InvestigationalProductType")
                        .WithMany()
                        .HasForeignKey("InvestigationalProductTypeId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.ReportType", "ReportType")
                        .WithMany()
                        .HasForeignKey("ReportTypeId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.ReportingType", "ReportingType")
                        .WithMany()
                        .HasForeignKey("ReportingTypeId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.SusarType", "SusarType")
                        .WithMany()
                        .HasForeignKey("SusarTypeId");

                    b.Navigation("CaseOrigin");

                    b.Navigation("Country");

                    b.Navigation("InstitutionType");

                    b.Navigation("InvestigationalProductType");

                    b.Navigation("ReportingType");

                    b.Navigation("ReportType");

                    b.Navigation("SusarType");
                });

            modelBuilder.Entity("Clinical_Trials_Adverse_Events_Reporting_System.Entities.NationalRequirementCountryRequirementVersion", b =>
                {
                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.CountryRequirementVersion", "CountryRequirementVersion")
                        .WithMany()
                        .HasForeignKey("CountryRequirementVersionId");

                    b.HasOne("Clinical_Trials_Adverse_Events_Reporting_System.Entities.NationalRequirement", "NationalRequirement")
                        .WithMany()
                        .HasForeignKey("NationalRequirementId");

                    b.Navigation("CountryRequirementVersion");

                    b.Navigation("NationalRequirement");
                });
#pragma warning restore 612, 618
        }
    }
}
