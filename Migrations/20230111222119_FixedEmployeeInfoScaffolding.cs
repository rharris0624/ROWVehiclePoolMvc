using Microsoft.EntityFrameworkCore.Migrations;

namespace RowVehiclePoolMVC.Migrations
{
    public partial class FixedEmployeeInfoScaffolding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VwEmployeeInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VwEmployeeInfos",
                columns: table => new
                {
                    EMPLOYEE_NUMBER = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    ITEM = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    JOB_TITLE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FIRST_NAME = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NAME_LAST = table.Column<string>(type: "varchar(27)", unicode: false, maxLength: 27, nullable: true),
                    SECTION_ID = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    SectionDesc = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });
        }
    }
}
