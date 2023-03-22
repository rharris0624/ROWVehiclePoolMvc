using Microsoft.EntityFrameworkCore.Migrations;

namespace RowVehiclePoolMVC.Migrations
{
    public partial class AddedViewEmployeeInfotry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "vwEmployeeInfo",
                newName: "VwEmployeeInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "VwEmployeeInfos",
                newName: "vwEmployeeInfo");
        }
    }
}
