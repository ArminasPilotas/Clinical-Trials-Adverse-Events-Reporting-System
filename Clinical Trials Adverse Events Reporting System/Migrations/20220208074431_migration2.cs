using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaseOrigin",
                table: "Classifiers");

            migrationBuilder.DropColumn(
                name: "InstitutionType",
                table: "Classifiers");

            migrationBuilder.DropColumn(
                name: "InvestigationalProductType",
                table: "Classifiers");

            migrationBuilder.DropColumn(
                name: "ReportType",
                table: "Classifiers");

            migrationBuilder.RenameColumn(
                name: "SusarType",
                table: "Classifiers",
                newName: "ModifyReason");

            migrationBuilder.RenameColumn(
                name: "ReportingType",
                table: "Classifiers",
                newName: "Editor");

            migrationBuilder.RenameColumn(
                name: "ReportingMethod",
                table: "Classifiers",
                newName: "Author");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Classifiers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Classifiers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Classifiers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Classifiers");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Classifiers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Classifiers");

            migrationBuilder.RenameColumn(
                name: "ModifyReason",
                table: "Classifiers",
                newName: "SusarType");

            migrationBuilder.RenameColumn(
                name: "Editor",
                table: "Classifiers",
                newName: "ReportingType");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Classifiers",
                newName: "ReportingMethod");

            migrationBuilder.AddColumn<string>(
                name: "CaseOrigin",
                table: "Classifiers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstitutionType",
                table: "Classifiers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvestigationalProductType",
                table: "Classifiers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReportType",
                table: "Classifiers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
