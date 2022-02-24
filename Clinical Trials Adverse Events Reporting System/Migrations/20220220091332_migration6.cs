using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionTypeId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternateAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternatePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternateEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternateFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Editor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institutions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Institutions_InstitutionTypes_InstitutionTypeId",
                        column: x => x.InstitutionTypeId,
                        principalTable: "InstitutionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NationalRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    ReportingTypeId = table.Column<int>(type: "int", nullable: true),
                    InstitutionTypeId = table.Column<int>(type: "int", nullable: true),
                    SusarTypeId = table.Column<int>(type: "int", nullable: true),
                    CaseOriginId = table.Column<int>(type: "int", nullable: true),
                    InvestigationalProductTypeId = table.Column<int>(type: "int", nullable: true),
                    ReportTypeId = table.Column<int>(type: "int", nullable: true),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Editor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationalRequirements_CaseOrigins_CaseOriginId",
                        column: x => x.CaseOriginId,
                        principalTable: "CaseOrigins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationalRequirements_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationalRequirements_InstitutionTypes_InstitutionTypeId",
                        column: x => x.InstitutionTypeId,
                        principalTable: "InstitutionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationalRequirements_InvestigationalProductTypes_InvestigationalProductTypeId",
                        column: x => x.InvestigationalProductTypeId,
                        principalTable: "InvestigationalProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationalRequirements_ReportingTypes_ReportingTypeId",
                        column: x => x.ReportingTypeId,
                        principalTable: "ReportingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationalRequirements_ReportTypes_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationalRequirements_SusarTypes_SusarTypeId",
                        column: x => x.SusarTypeId,
                        principalTable: "SusarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_CountryId",
                table: "Institutions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_InstitutionTypeId",
                table: "Institutions",
                column: "InstitutionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirements_CaseOriginId",
                table: "NationalRequirements",
                column: "CaseOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirements_CountryId",
                table: "NationalRequirements",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirements_InstitutionTypeId",
                table: "NationalRequirements",
                column: "InstitutionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirements_InvestigationalProductTypeId",
                table: "NationalRequirements",
                column: "InvestigationalProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirements_ReportingTypeId",
                table: "NationalRequirements",
                column: "ReportingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirements_ReportTypeId",
                table: "NationalRequirements",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirements_SusarTypeId",
                table: "NationalRequirements",
                column: "SusarTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "NationalRequirements");
        }
    }
}
