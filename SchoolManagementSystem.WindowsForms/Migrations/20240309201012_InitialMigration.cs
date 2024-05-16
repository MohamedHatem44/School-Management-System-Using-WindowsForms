using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses_Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CStudentCourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses_Students", x => new { x.StudentID, x.CStudentCourseID });
                    table.ForeignKey(
                        name: "FK_Courses_Students_Courses_CStudentCourseID",
                        column: x => x.CStudentCourseID,
                        principalTable: "Courses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Courses_Students_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CoursesSessions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "GETDATE()"),
                    Title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, defaultValue: "No Title"),
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    CSessionCourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesSessions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CoursesSessions_Courses_CSessionCourseID",
                        column: x => x.CSessionCourseID,
                        principalTable: "Courses",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CoursesSessionsAttendance",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "varchar(max)", maxLength: 255, nullable: true, defaultValue: "No Notes"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CourseSessionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesSessionsAttendance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CoursesSessionsAttendance_CoursesSessions_CourseSessionID",
                        column: x => x.CourseSessionID,
                        principalTable: "CoursesSessions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesSessionsAttendance_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ManagerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentID",
                table: "Courses",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorID",
                table: "Courses",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Students_CStudentCourseID",
                table: "Courses_Students",
                column: "CStudentCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessions_CSessionCourseID",
                table: "CoursesSessions",
                column: "CSessionCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessions_InstructorID",
                table: "CoursesSessions",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessionsAttendance_CourseSessionID",
                table: "CoursesSessionsAttendance",
                column: "CourseSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessionsAttendance_StudentID",
                table: "CoursesSessionsAttendance",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID",
                unique: true,
                filter: "[ManagerID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentID",
                table: "Instructors",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorID",
                table: "Courses",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesSessions_Instructors_InstructorID",
                table: "CoursesSessions",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments",
                column: "ManagerID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "Courses_Students");

            migrationBuilder.DropTable(
                name: "CoursesSessionsAttendance");

            migrationBuilder.DropTable(
                name: "CoursesSessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
