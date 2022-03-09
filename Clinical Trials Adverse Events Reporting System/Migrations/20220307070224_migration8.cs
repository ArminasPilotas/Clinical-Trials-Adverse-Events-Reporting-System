using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    public partial class migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryRequirementVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    DateOfRenewal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequirementVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactRevisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestigationalProductTypeId = table.Column<int>(type: "int", nullable: true),
                    Editor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryRequirementVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryRequirementVersions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryRequirementVersions_InvestigationalProductTypes_InvestigationalProductTypeId",
                        column: x => x.InvestigationalProductTypeId,
                        principalTable: "InvestigationalProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NationalRequirementCountryRequirementVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryRequirementVersionId = table.Column<int>(type: "int", nullable: true),
                    NationalRequirementId = table.Column<int>(type: "int", nullable: true),
                    Editor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalRequirementCountryRequirementVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationalRequirementCountryRequirementVersions_CountryRequirementVersions_CountryRequirementVersionId",
                        column: x => x.CountryRequirementVersionId,
                        principalTable: "CountryRequirementVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationalRequirementCountryRequirementVersions_NationalRequirements_NationalRequirementId",
                        column: x => x.NationalRequirementId,
                        principalTable: "NationalRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryRequirementVersions_CountryId",
                table: "CountryRequirementVersions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryRequirementVersions_InvestigationalProductTypeId",
                table: "CountryRequirementVersions",
                column: "InvestigationalProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirementCountryRequirementVersions_CountryRequirementVersionId",
                table: "NationalRequirementCountryRequirementVersions",
                column: "CountryRequirementVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalRequirementCountryRequirementVersions_NationalRequirementId",
                table: "NationalRequirementCountryRequirementVersions",
                column: "NationalRequirementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalRequirementCountryRequirementVersions");

            migrationBuilder.DropTable(
                name: "CountryRequirementVersions");
        }
    }
}
