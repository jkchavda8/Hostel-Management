using Microsoft.EntityFrameworkCore.Migrations;

namespace Hostel_Management.Migrations
{
    public partial class fee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "FeeHistories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "year",
                table: "FeeHistories");
        }
    }
}
