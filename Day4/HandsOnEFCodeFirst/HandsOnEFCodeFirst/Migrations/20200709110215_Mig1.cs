using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnEFCodeFirst.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OId = table.Column<string>(maxLength: 5, nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Pid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OId);
                    table.ForeignKey(
                        name: "FK_Order_Products_Pid",
                        column: x => x.Pid,
                        principalTable: "Products",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Pid",
                table: "Order",
                column: "Pid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
