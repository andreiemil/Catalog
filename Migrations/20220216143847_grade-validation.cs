using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Migrations
{
    public partial class gradevalidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegistrationNumber",
                table: "Student",
                type: "int",
                precision: 4,
                scale: 0,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ExamGrade",
                table: "Grade",
                type: "float(3)",
                precision: 3,
                scale: 2,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float(4)",
                oldPrecision: 4,
                oldScale: 2,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegistrationNumber",
                table: "Student",
                type: "int",
                precision: 4,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 4,
                oldScale: 0);

            migrationBuilder.AlterColumn<double>(
                name: "ExamGrade",
                table: "Grade",
                type: "float(4)",
                precision: 4,
                scale: 2,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float(3)",
                oldPrecision: 3,
                oldScale: 2);
        }
    }
}
