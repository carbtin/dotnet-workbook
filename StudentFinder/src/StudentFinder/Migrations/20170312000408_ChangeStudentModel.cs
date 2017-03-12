using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentFinder.Migrations
{
    public partial class ChangeStudentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "StudentsSchool",
                table: "Student",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentsSchool",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Student",
                nullable: false,
                defaultValue: 0);
        }
    }
}
