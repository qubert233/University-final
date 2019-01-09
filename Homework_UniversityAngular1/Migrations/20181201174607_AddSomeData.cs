using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.WebApp.Migrations
{
    public partial class AddSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbDepartments",
                keyColumn: "Id",
                keyValue: new Guid("61d0f123-45fe-4e95-b926-95c412beed0c"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("65ece990-ff76-4a11-89f1-c0f20bb1aac5"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("7b2c23fa-d289-4a14-83af-5da834bf7869"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("8b7d2977-6060-45a7-9835-e4a47aa7ba0f"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("ce6011c6-41a9-44e2-8eba-7cb84f456067"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("db5f669e-514b-4071-a544-68f90c7785a3"));

            migrationBuilder.InsertData(
                table: "tbDepartments",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33182"), "Programming and System Analysis" });

            migrationBuilder.InsertData(
                table: "tbSubjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33183"), "Calculus" },
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33184"), "Math Analysis" },
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33185"), "Operation Systems" },
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33186"), "Databases Theory" },
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33187"), "Application Testing" }
                });

            migrationBuilder.InsertData(
                table: "tbTeachers",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33483"), null, "Dean", "Moriarty", "Unknown" },
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33583"), null, "Sal", "Paradise", "Unknown" },
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33383"), null, "Tyler", "Durden", "Unknown" },
                    { new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33283"), null, "Max", "Frei", "Unknown" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbDepartments",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33182"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33183"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33184"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33185"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33186"));

            migrationBuilder.DeleteData(
                table: "tbSubjects",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33187"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad03280"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad13280"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad23280"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33280"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33283"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33383"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33483"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33583"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad43280"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad53280"));

            migrationBuilder.DeleteData(
                table: "tbTeachers",
                keyColumn: "Id",
                keyValue: new Guid("ed0758d1-0d55-4a99-8c21-4f147ad63280"));

            migrationBuilder.InsertData(
                table: "tbDepartments",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("61d0f123-45fe-4e95-b926-95c412beed0c"), "Programming and System Analysis" });

            migrationBuilder.InsertData(
                table: "tbSubjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("db5f669e-514b-4071-a544-68f90c7785a3"), "Calculus" },
                    { new Guid("7b2c23fa-d289-4a14-83af-5da834bf7869"), "Math Analysis" },
                    { new Guid("8b7d2977-6060-45a7-9835-e4a47aa7ba0f"), "Operation Systems" },
                    { new Guid("ce6011c6-41a9-44e2-8eba-7cb84f456067"), "Databases Theory" },
                    { new Guid("65ece990-ff76-4a11-89f1-c0f20bb1aac5"), "Application Testing" }
                });
        }
    }
}
