using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Migrations
{
    public partial class registrationnb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegistrationNumber",
                table: "Student",
                type: "int",
                precision: 4,
                scale: 0,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldPrecision: 4,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RegistrationNumber",
                table: "Student",
                type: "nvarchar(max)",
                precision: 4,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 4,
                oldScale: 0,
                oldNullable: true);
        }
    }
}
