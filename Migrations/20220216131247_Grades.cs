using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Migrations
{
    public partial class Grades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Course_CourseId",
                table: "Grade");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Grade",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Course_CourseId",
                table: "Grade",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Course_CourseId",
                table: "Grade");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Grade",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Course_CourseId",
                table: "Grade",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }
    }
}
