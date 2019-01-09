using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbAudiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAudiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbDepartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbLections",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Start = table.Column<DateTime>(type: "datetime", nullable: false),
                    Finish = table.Column<DateTime>(type: "datetime", nullable: false),
                    Day = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbSpeciality",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSpeciality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbSubjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSubjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbTeachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 64, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 64, nullable: true),
                    LastName = table.Column<string>(maxLength: 64, nullable: true),
                    DepartmentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbTeachers_tbDepartments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tbDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: true),
                    SpecialityId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbGroups_tbSpeciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "tbSpeciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbTeachSubj",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TeacherId = table.Column<Guid>(nullable: false),
                    SubjId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTeachSubj", x => new { x.TeacherId, x.SubjId });
                    table.UniqueConstraint("AK_tbTeachSubj_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbTeachSubj_tbSubjects_SubjId",
                        column: x => x.SubjId,
                        principalTable: "tbSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbTeachSubj_tbTeachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "tbTeachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbStudents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 64, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 64, nullable: true),
                    LastName = table.Column<string>(maxLength: 64, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    LogbookNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 64, nullable: true),
                    Address = table.Column<string>(maxLength: 128, nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbStudents_tbGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "tbGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbAudLect",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AudId = table.Column<Guid>(nullable: false),
                    LectId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false),
                    TeachSubjTeacherId = table.Column<Guid>(nullable: true),
                    TeachSubjSubjId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAudLect", x => new { x.AudId, x.LectId, x.GroupId });
                    table.UniqueConstraint("AK_tbAudLect_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbAudLect_tbAudiences_AudId",
                        column: x => x.AudId,
                        principalTable: "tbAudiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbAudLect_tbGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "tbGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbAudLect_tbLections_LectId",
                        column: x => x.LectId,
                        principalTable: "tbLections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbAudLect_tbTeachSubj_TeachSubjTeacherId_TeachSubjSubjId",
                        columns: x => new { x.TeachSubjTeacherId, x.TeachSubjSubjId },
                        principalTable: "tbTeachSubj",
                        principalColumns: new[] { "TeacherId", "SubjId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbMarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StudentsMark = table.Column<int>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: true),
                    TeachSubjTeacherId = table.Column<Guid>(nullable: true),
                    TeachSubjSubjId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMarks_tbStudents_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tbStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbMarks_tbTeachSubj_TeachSubjTeacherId_TeachSubjSubjId",
                        columns: x => new { x.TeachSubjTeacherId, x.TeachSubjSubjId },
                        principalTable: "tbTeachSubj",
                        principalColumns: new[] { "TeacherId", "SubjId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbPhones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StudentsPhone = table.Column<string>(maxLength: 64, nullable: true),
                    StudentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbPhones_tbStudents_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tbStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbAudLect_GroupId",
                table: "tbAudLect",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_tbAudLect_LectId",
                table: "tbAudLect",
                column: "LectId");

            migrationBuilder.CreateIndex(
                name: "IX_tbAudLect_TeachSubjTeacherId_TeachSubjSubjId",
                table: "tbAudLect",
                columns: new[] { "TeachSubjTeacherId", "TeachSubjSubjId" });

            migrationBuilder.CreateIndex(
                name: "IX_tbGroups_SpecialityId",
                table: "tbGroups",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMarks_StudentId",
                table: "tbMarks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMarks_TeachSubjTeacherId_TeachSubjSubjId",
                table: "tbMarks",
                columns: new[] { "TeachSubjTeacherId", "TeachSubjSubjId" });

            migrationBuilder.CreateIndex(
                name: "IX_tbPhones_StudentId",
                table: "tbPhones",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbStudents_GroupId",
                table: "tbStudents",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_tbTeachers_DepartmentId",
                table: "tbTeachers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbTeachSubj_SubjId",
                table: "tbTeachSubj",
                column: "SubjId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbAudLect");

            migrationBuilder.DropTable(
                name: "tbMarks");

            migrationBuilder.DropTable(
                name: "tbPhones");

            migrationBuilder.DropTable(
                name: "tbAudiences");

            migrationBuilder.DropTable(
                name: "tbLections");

            migrationBuilder.DropTable(
                name: "tbTeachSubj");

            migrationBuilder.DropTable(
                name: "tbStudents");

            migrationBuilder.DropTable(
                name: "tbSubjects");

            migrationBuilder.DropTable(
                name: "tbTeachers");

            migrationBuilder.DropTable(
                name: "tbGroups");

            migrationBuilder.DropTable(
                name: "tbDepartments");

            migrationBuilder.DropTable(
                name: "tbSpeciality");
        }
    }
}
