using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentFinder.Migrations
{
    public partial class JoinMapModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Student_StudentId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Space_Schedule_ScheduleId",
                table: "Space");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Space_SpaceId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_SpaceId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Space_ScheduleId",
                table: "Space");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "SpaceId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Schedule");

            migrationBuilder.CreateTable(
                name: "StudentScheduleSpace",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: false),
                    SpaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentScheduleSpace", x => new { x.StudentId, x.ScheduleId, x.SpaceId });
                    table.ForeignKey(
                        name: "FK_StudentScheduleSpace_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentScheduleSpace_Space_SpaceId",
                        column: x => x.SpaceId,
                        principalTable: "Space",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentScheduleSpace_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentScheduleSpace_ScheduleId",
                table: "StudentScheduleSpace",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScheduleSpace_SpaceId",
                table: "StudentScheduleSpace",
                column: "SpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScheduleSpace_StudentId",
                table: "StudentScheduleSpace",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentScheduleSpace");

            migrationBuilder.AddColumn<int>(
                name: "SpaceId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Space",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_SpaceId",
                table: "Student",
                column: "SpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Space_ScheduleId",
                table: "Space",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Student_StudentId",
                table: "Schedule",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Space_Schedule_ScheduleId",
                table: "Space",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Space_SpaceId",
                table: "Student",
                column: "SpaceId",
                principalTable: "Space",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
