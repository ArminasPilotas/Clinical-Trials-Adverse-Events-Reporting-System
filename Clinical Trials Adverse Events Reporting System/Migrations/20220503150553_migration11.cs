using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    public partial class migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdverseEvents_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "AdverseEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Authorities_Countries_CountryId",
                table: "Authorities");

            migrationBuilder.DropForeignKey(
                name: "FK_Authorities_Institutions_InstitutionId",
                table: "Authorities");

            migrationBuilder.DropForeignKey(
                name: "FK_Authorities_InstitutionTypes_InstitutionTypeId",
                table: "Authorities");

            migrationBuilder.DropForeignKey(
                name: "FK_Authorities_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "Authorities");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryRequirementVersions_Countries_CountryId",
                table: "CountryRequirementVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryRequirementVersions_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "CountryRequirementVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_Countries_CountryId",
                table: "Institutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_InstitutionTypes_InstitutionTypeId",
                table: "Institutions");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirementCountryRequirementVersions_CountryRequirementVersions_CountryRequirementVersionId",
                table: "NationalRequirementCountryRequirementVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirementCountryRequirementVersions_NationalRequirements_NationalRequirementId",
                table: "NationalRequirementCountryRequirementVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirements_CaseOrigins_CaseOriginId",
                table: "NationalRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirements_Countries_CountryId",
                table: "NationalRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirements_InstitutionTypes_InstitutionTypeId",
                table: "NationalRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirements_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "NationalRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirements_ReportingTypes_ReportingTypeId",
                table: "NationalRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirements_ReportTypes_ReportTypeId",
                table: "NationalRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirements_SusarTypes_SusarTypeId",
                table: "NationalRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportedInstitutions_AdverseEvents_AdverseEventId",
                table: "ReportedInstitutions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportedInstitutions_Institutions_InstitutionId",
                table: "ReportedInstitutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SusarTypes",
                table: "SusarTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportTypes",
                table: "ReportTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportingTypes",
                table: "ReportingTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportingMethods",
                table: "ReportingMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportedInstitutions",
                table: "ReportedInstitutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalRequirements",
                table: "NationalRequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalRequirementCountryRequirementVersions",
                table: "NationalRequirementCountryRequirementVersions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvestigationalProductTypes",
                table: "InvestigationalProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstitutionTypes",
                table: "InstitutionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institutions",
                table: "Institutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryRequirementVersions",
                table: "CountryRequirementVersions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseOrigins",
                table: "CaseOrigins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authorities",
                table: "Authorities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdverseEvents",
                table: "AdverseEvents");

            migrationBuilder.RenameTable(
                name: "SusarTypes",
                newName: "SusarType");

            migrationBuilder.RenameTable(
                name: "ReportTypes",
                newName: "ReportType");

            migrationBuilder.RenameTable(
                name: "ReportingTypes",
                newName: "ReportingType");

            migrationBuilder.RenameTable(
                name: "ReportingMethods",
                newName: "ReportingMethod");

            migrationBuilder.RenameTable(
                name: "ReportedInstitutions",
                newName: "ReportedInstitution");

            migrationBuilder.RenameTable(
                name: "NationalRequirements",
                newName: "NationalRequirement");

            migrationBuilder.RenameTable(
                name: "NationalRequirementCountryRequirementVersions",
                newName: "NationalRequirementVersion");

            migrationBuilder.RenameTable(
                name: "InvestigationalProductTypes",
                newName: "InvestigationalProductType");

            migrationBuilder.RenameTable(
                name: "InstitutionTypes",
                newName: "InstitutionType");

            migrationBuilder.RenameTable(
                name: "Institutions",
                newName: "Institution");

            migrationBuilder.RenameTable(
                name: "CountryRequirementVersions",
                newName: "CountryRequirementVersion");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "CaseOrigins",
                newName: "CaseOrigin");

            migrationBuilder.RenameTable(
                name: "Authorities",
                newName: "Authority");

            migrationBuilder.RenameTable(
                name: "AdverseEvents",
                newName: "AdverseEvent");

            migrationBuilder.RenameIndex(
                name: "IX_ReportedInstitutions_InstitutionId",
                table: "ReportedInstitution",
                newName: "IX_ReportedInstitution_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_ReportedInstitutions_AdverseEventId",
                table: "ReportedInstitution",
                newName: "IX_ReportedInstitution_AdverseEventId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirements_SusarTypeId",
                table: "NationalRequirement",
                newName: "IX_NationalRequirement_SusarTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirements_ReportTypeId",
                table: "NationalRequirement",
                newName: "IX_NationalRequirement_ReportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirements_ReportingTypeId",
                table: "NationalRequirement",
                newName: "IX_NationalRequirement_ReportingTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirements_InvestigationalProductTypeId",
                table: "NationalRequirement",
                newName: "IX_NationalRequirement_InvestigationalProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirements_InstitutionTypeId",
                table: "NationalRequirement",
                newName: "IX_NationalRequirement_InstitutionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirements_CountryId",
                table: "NationalRequirement",
                newName: "IX_NationalRequirement_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirements_CaseOriginId",
                table: "NationalRequirement",
                newName: "IX_NationalRequirement_CaseOriginId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirementCountryRequirementVersions_NationalRequirementId",
                table: "NationalRequirementVersion",
                newName: "IX_NationalRequirementVersion_NationalRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirementCountryRequirementVersions_CountryRequirementVersionId",
                table: "NationalRequirementVersion",
                newName: "IX_NationalRequirementVersion_CountryRequirementVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_Institutions_InstitutionTypeId",
                table: "Institution",
                newName: "IX_Institution_InstitutionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Institutions_CountryId",
                table: "Institution",
                newName: "IX_Institution_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_CountryRequirementVersions_InvestigationalProductTypeId",
                table: "CountryRequirementVersion",
                newName: "IX_CountryRequirementVersion_InvestigationalProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CountryRequirementVersions_CountryId",
                table: "CountryRequirementVersion",
                newName: "IX_CountryRequirementVersion_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Authorities_InvestigationalProductTypeId",
                table: "Authority",
                newName: "IX_Authority_InvestigationalProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Authorities_InstitutionTypeId",
                table: "Authority",
                newName: "IX_Authority_InstitutionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Authorities_InstitutionId",
                table: "Authority",
                newName: "IX_Authority_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_Authorities_CountryId",
                table: "Authority",
                newName: "IX_Authority_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_AdverseEvents_InvestigationalProductTypeId",
                table: "AdverseEvent",
                newName: "IX_AdverseEvent_InvestigationalProductTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "StudyNo",
                table: "AdverseEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AdverseEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SusarType",
                table: "SusarType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportType",
                table: "ReportType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportingType",
                table: "ReportingType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportingMethod",
                table: "ReportingMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportedInstitution",
                table: "ReportedInstitution",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalRequirement",
                table: "NationalRequirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalRequirementVersion",
                table: "NationalRequirementVersion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvestigationalProductType",
                table: "InvestigationalProductType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstitutionType",
                table: "InstitutionType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institution",
                table: "Institution",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryRequirementVersion",
                table: "CountryRequirementVersion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseOrigin",
                table: "CaseOrigin",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authority",
                table: "Authority",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdverseEvent",
                table: "AdverseEvent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdverseEvent_InvestigationalProductType_InvestigationalProductTypeId",
                table: "AdverseEvent",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authority_Country_CountryId",
                table: "Authority",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authority_Institution_InstitutionId",
                table: "Authority",
                column: "InstitutionId",
                principalTable: "Institution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authority_InstitutionType_InstitutionTypeId",
                table: "Authority",
                column: "InstitutionTypeId",
                principalTable: "InstitutionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authority_InvestigationalProductType_InvestigationalProductTypeId",
                table: "Authority",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryRequirementVersion_Country_CountryId",
                table: "CountryRequirementVersion",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryRequirementVersion_InvestigationalProductType_InvestigationalProductTypeId",
                table: "CountryRequirementVersion",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institution_Country_CountryId",
                table: "Institution",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institution_InstitutionType_InstitutionTypeId",
                table: "Institution",
                column: "InstitutionTypeId",
                principalTable: "InstitutionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirement_CaseOrigin_CaseOriginId",
                table: "NationalRequirement",
                column: "CaseOriginId",
                principalTable: "CaseOrigin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirement_Country_CountryId",
                table: "NationalRequirement",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirement_InstitutionType_InstitutionTypeId",
                table: "NationalRequirement",
                column: "InstitutionTypeId",
                principalTable: "InstitutionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirement_InvestigationalProductType_InvestigationalProductTypeId",
                table: "NationalRequirement",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirement_ReportingType_ReportingTypeId",
                table: "NationalRequirement",
                column: "ReportingTypeId",
                principalTable: "ReportingType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirement_ReportType_ReportTypeId",
                table: "NationalRequirement",
                column: "ReportTypeId",
                principalTable: "ReportType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirement_SusarType_SusarTypeId",
                table: "NationalRequirement",
                column: "SusarTypeId",
                principalTable: "SusarType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirementVersion_CountryRequirementVersion_CountryRequirementVersionId",
                table: "NationalRequirementVersion",
                column: "CountryRequirementVersionId",
                principalTable: "CountryRequirementVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirementVersion_NationalRequirement_NationalRequirementId",
                table: "NationalRequirementVersion",
                column: "NationalRequirementId",
                principalTable: "NationalRequirement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportedInstitution_AdverseEvent_AdverseEventId",
                table: "ReportedInstitution",
                column: "AdverseEventId",
                principalTable: "AdverseEvent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportedInstitution_Institution_InstitutionId",
                table: "ReportedInstitution",
                column: "InstitutionId",
                principalTable: "Institution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdverseEvent_InvestigationalProductType_InvestigationalProductTypeId",
                table: "AdverseEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Authority_Country_CountryId",
                table: "Authority");

            migrationBuilder.DropForeignKey(
                name: "FK_Authority_Institution_InstitutionId",
                table: "Authority");

            migrationBuilder.DropForeignKey(
                name: "FK_Authority_InstitutionType_InstitutionTypeId",
                table: "Authority");

            migrationBuilder.DropForeignKey(
                name: "FK_Authority_InvestigationalProductType_InvestigationalProductTypeId",
                table: "Authority");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryRequirementVersion_Country_CountryId",
                table: "CountryRequirementVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryRequirementVersion_InvestigationalProductType_InvestigationalProductTypeId",
                table: "CountryRequirementVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_Institution_Country_CountryId",
                table: "Institution");

            migrationBuilder.DropForeignKey(
                name: "FK_Institution_InstitutionType_InstitutionTypeId",
                table: "Institution");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirement_CaseOrigin_CaseOriginId",
                table: "NationalRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirement_Country_CountryId",
                table: "NationalRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirement_InstitutionType_InstitutionTypeId",
                table: "NationalRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirement_InvestigationalProductType_InvestigationalProductTypeId",
                table: "NationalRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirement_ReportingType_ReportingTypeId",
                table: "NationalRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirement_ReportType_ReportTypeId",
                table: "NationalRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirement_SusarType_SusarTypeId",
                table: "NationalRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirementVersion_CountryRequirementVersion_CountryRequirementVersionId",
                table: "NationalRequirementVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_NationalRequirementVersion_NationalRequirement_NationalRequirementId",
                table: "NationalRequirementVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportedInstitution_AdverseEvent_AdverseEventId",
                table: "ReportedInstitution");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportedInstitution_Institution_InstitutionId",
                table: "ReportedInstitution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SusarType",
                table: "SusarType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportType",
                table: "ReportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportingType",
                table: "ReportingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportingMethod",
                table: "ReportingMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportedInstitution",
                table: "ReportedInstitution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalRequirementVersion",
                table: "NationalRequirementVersion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalRequirement",
                table: "NationalRequirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvestigationalProductType",
                table: "InvestigationalProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstitutionType",
                table: "InstitutionType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institution",
                table: "Institution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryRequirementVersion",
                table: "CountryRequirementVersion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseOrigin",
                table: "CaseOrigin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authority",
                table: "Authority");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdverseEvent",
                table: "AdverseEvent");

            migrationBuilder.RenameTable(
                name: "SusarType",
                newName: "SusarTypes");

            migrationBuilder.RenameTable(
                name: "ReportType",
                newName: "ReportTypes");

            migrationBuilder.RenameTable(
                name: "ReportingType",
                newName: "ReportingTypes");

            migrationBuilder.RenameTable(
                name: "ReportingMethod",
                newName: "ReportingMethods");

            migrationBuilder.RenameTable(
                name: "ReportedInstitution",
                newName: "ReportedInstitutions");

            migrationBuilder.RenameTable(
                name: "NationalRequirementVersion",
                newName: "NationalRequirementCountryRequirementVersions");

            migrationBuilder.RenameTable(
                name: "NationalRequirement",
                newName: "NationalRequirements");

            migrationBuilder.RenameTable(
                name: "InvestigationalProductType",
                newName: "InvestigationalProductTypes");

            migrationBuilder.RenameTable(
                name: "InstitutionType",
                newName: "InstitutionTypes");

            migrationBuilder.RenameTable(
                name: "Institution",
                newName: "Institutions");

            migrationBuilder.RenameTable(
                name: "CountryRequirementVersion",
                newName: "CountryRequirementVersions");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "CaseOrigin",
                newName: "CaseOrigins");

            migrationBuilder.RenameTable(
                name: "Authority",
                newName: "Authorities");

            migrationBuilder.RenameTable(
                name: "AdverseEvent",
                newName: "AdverseEvents");

            migrationBuilder.RenameIndex(
                name: "IX_ReportedInstitution_InstitutionId",
                table: "ReportedInstitutions",
                newName: "IX_ReportedInstitutions_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_ReportedInstitution_AdverseEventId",
                table: "ReportedInstitutions",
                newName: "IX_ReportedInstitutions_AdverseEventId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirementVersion_NationalRequirementId",
                table: "NationalRequirementCountryRequirementVersions",
                newName: "IX_NationalRequirementCountryRequirementVersions_NationalRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirementVersion_CountryRequirementVersionId",
                table: "NationalRequirementCountryRequirementVersions",
                newName: "IX_NationalRequirementCountryRequirementVersions_CountryRequirementVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirement_SusarTypeId",
                table: "NationalRequirements",
                newName: "IX_NationalRequirements_SusarTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirement_ReportTypeId",
                table: "NationalRequirements",
                newName: "IX_NationalRequirements_ReportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirement_ReportingTypeId",
                table: "NationalRequirements",
                newName: "IX_NationalRequirements_ReportingTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirement_InvestigationalProductTypeId",
                table: "NationalRequirements",
                newName: "IX_NationalRequirements_InvestigationalProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirement_InstitutionTypeId",
                table: "NationalRequirements",
                newName: "IX_NationalRequirements_InstitutionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirement_CountryId",
                table: "NationalRequirements",
                newName: "IX_NationalRequirements_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_NationalRequirement_CaseOriginId",
                table: "NationalRequirements",
                newName: "IX_NationalRequirements_CaseOriginId");

            migrationBuilder.RenameIndex(
                name: "IX_Institution_InstitutionTypeId",
                table: "Institutions",
                newName: "IX_Institutions_InstitutionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Institution_CountryId",
                table: "Institutions",
                newName: "IX_Institutions_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_CountryRequirementVersion_InvestigationalProductTypeId",
                table: "CountryRequirementVersions",
                newName: "IX_CountryRequirementVersions_InvestigationalProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CountryRequirementVersion_CountryId",
                table: "CountryRequirementVersions",
                newName: "IX_CountryRequirementVersions_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Authority_InvestigationalProductTypeId",
                table: "Authorities",
                newName: "IX_Authorities_InvestigationalProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Authority_InstitutionTypeId",
                table: "Authorities",
                newName: "IX_Authorities_InstitutionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Authority_InstitutionId",
                table: "Authorities",
                newName: "IX_Authorities_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_Authority_CountryId",
                table: "Authorities",
                newName: "IX_Authorities_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_AdverseEvent_InvestigationalProductTypeId",
                table: "AdverseEvents",
                newName: "IX_AdverseEvents_InvestigationalProductTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "StudyNo",
                table: "AdverseEvents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AdverseEvents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SusarTypes",
                table: "SusarTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportTypes",
                table: "ReportTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportingTypes",
                table: "ReportingTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportingMethods",
                table: "ReportingMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportedInstitutions",
                table: "ReportedInstitutions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalRequirementCountryRequirementVersions",
                table: "NationalRequirementCountryRequirementVersions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalRequirements",
                table: "NationalRequirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvestigationalProductTypes",
                table: "InvestigationalProductTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstitutionTypes",
                table: "InstitutionTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institutions",
                table: "Institutions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryRequirementVersions",
                table: "CountryRequirementVersions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseOrigins",
                table: "CaseOrigins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authorities",
                table: "Authorities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdverseEvents",
                table: "AdverseEvents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdverseEvents_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "AdverseEvents",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authorities_Countries_CountryId",
                table: "Authorities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authorities_Institutions_InstitutionId",
                table: "Authorities",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authorities_InstitutionTypes_InstitutionTypeId",
                table: "Authorities",
                column: "InstitutionTypeId",
                principalTable: "InstitutionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authorities_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "Authorities",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryRequirementVersions_Countries_CountryId",
                table: "CountryRequirementVersions",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryRequirementVersions_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "CountryRequirementVersions",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_Countries_CountryId",
                table: "Institutions",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_InstitutionTypes_InstitutionTypeId",
                table: "Institutions",
                column: "InstitutionTypeId",
                principalTable: "InstitutionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirementCountryRequirementVersions_CountryRequirementVersions_CountryRequirementVersionId",
                table: "NationalRequirementCountryRequirementVersions",
                column: "CountryRequirementVersionId",
                principalTable: "CountryRequirementVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirementCountryRequirementVersions_NationalRequirements_NationalRequirementId",
                table: "NationalRequirementCountryRequirementVersions",
                column: "NationalRequirementId",
                principalTable: "NationalRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirements_CaseOrigins_CaseOriginId",
                table: "NationalRequirements",
                column: "CaseOriginId",
                principalTable: "CaseOrigins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirements_Countries_CountryId",
                table: "NationalRequirements",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirements_InstitutionTypes_InstitutionTypeId",
                table: "NationalRequirements",
                column: "InstitutionTypeId",
                principalTable: "InstitutionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirements_InvestigationalProductTypes_InvestigationalProductTypeId",
                table: "NationalRequirements",
                column: "InvestigationalProductTypeId",
                principalTable: "InvestigationalProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirements_ReportingTypes_ReportingTypeId",
                table: "NationalRequirements",
                column: "ReportingTypeId",
                principalTable: "ReportingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirements_ReportTypes_ReportTypeId",
                table: "NationalRequirements",
                column: "ReportTypeId",
                principalTable: "ReportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationalRequirements_SusarTypes_SusarTypeId",
                table: "NationalRequirements",
                column: "SusarTypeId",
                principalTable: "SusarTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportedInstitutions_AdverseEvents_AdverseEventId",
                table: "ReportedInstitutions",
                column: "AdverseEventId",
                principalTable: "AdverseEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportedInstitutions_Institutions_InstitutionId",
                table: "ReportedInstitutions",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
