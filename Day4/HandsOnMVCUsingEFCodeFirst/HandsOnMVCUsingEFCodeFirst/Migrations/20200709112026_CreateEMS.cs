using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnMVCUsingEFCodeFirst.Migrations
{
    public partial class CreateEMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Eid = table.Column<string>(maxLength: 5, nullable: false),
                    Ename = table.Column<string>(maxLength: 30, nullable: false),
                    JoinDate = table.Column<DateTime>(nullable: true),
                    Salary = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Eid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
