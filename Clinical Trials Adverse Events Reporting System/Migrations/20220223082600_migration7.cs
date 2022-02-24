using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    public partial class migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    InvestigationalProductTypeId = table.Column<int>(type: "int", nullable: true),
                    InstitutionTypeId = table.Column<int>(type: "int", nullable: true),
                    InstitutionId = table.Column<int>(type: "int", nullable: true),
                    Editor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authorities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorities_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorities_InstitutionTypes_InstitutionTypeId",
                        column: x => x.InstitutionTypeId,
                        principalTable: "InstitutionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorities_InvestigationalProductTypes_InvestigationalProductTypeId",
                        column: x => x.InvestigationalProductTypeId,
                        principalTable: "InvestigationalProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_CountryId",
                table: "Authorities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_InstitutionId",
                table: "Authorities",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_InstitutionTypeId",
                table: "Authorities",
                column: "InstitutionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_InvestigationalProductTypeId",
                table: "Authorities",
                column: "InvestigationalProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authorities");
        }
    }
}
