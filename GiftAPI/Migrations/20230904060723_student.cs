using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftAPI.Migrations
{
    public partial class student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentRegistration",
                columns: table => new
                {
                    studentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobilenumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRegistration", x => x.studentid);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    courseid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.courseid);
                    table.ForeignKey(
                        name: "FK_Course_StudentRegistration_studentid",
                        column: x => x.studentid,
                        principalTable: "StudentRegistration",
                        principalColumn: "studentid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_studentid",
                table: "Course",
                column: "studentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "StudentRegistration");
        }
    }
}
