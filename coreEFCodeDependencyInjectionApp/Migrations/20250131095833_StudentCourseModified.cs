﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreEFCodeDependencyInjectionApp.Migrations
{
    /// <inheritdoc />
    public partial class StudentCourseModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
