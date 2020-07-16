using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnMVCUsingEFCodeFirst.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Salary",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Employee",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
