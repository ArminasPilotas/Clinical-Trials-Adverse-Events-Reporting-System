using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classifiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportingMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstitutionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SusarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestigationalProductType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifiers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classifiers");
        }
    }
}
