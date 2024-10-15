using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hostel_Management.Migrations
{
    public partial class reason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalDate",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<string>(
                name: "reason",
                table: "LeaveRequests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reason",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovalDate",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: true);
        }
    }
}
