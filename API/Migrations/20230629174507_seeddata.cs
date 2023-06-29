using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyCVSite.API.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgrammingSkillProject",
                table: "ProgrammingSkillProject");

            migrationBuilder.DropIndex(
                name: "IX_ProgrammingSkillProject_SkillsID",
                table: "ProgrammingSkillProject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgrammingSkillProject",
                table: "ProgrammingSkillProject",
                columns: new[] { "SkillsID", "ProjectsID" });

            migrationBuilder.InsertData(
                table: "ProgrammingSkills",
                columns: new[] { "ID", "Category", "KnownFrom", "Name" },
                values: new object[,]
                {
                    { 1, "Languages", new DateTime(2022, 6, 29, 20, 45, 7, 197, DateTimeKind.Local).AddTicks(2311), "C#" },
                    { 2, "Languages", new DateTime(2020, 6, 29, 20, 45, 7, 197, DateTimeKind.Local).AddTicks(2318), "JavaScript" },
                    { 3, "Libraries", new DateTime(2021, 6, 29, 20, 45, 7, 197, DateTimeKind.Local).AddTicks(2321), "React" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Description", "GitURL", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "A mock project", "https://github.com/Simonsbs", "Mock Project 1", "https://google.com" },
                    { 2, "A mock project", "https://github.com/Simonsbs", "Mock Project 2", "https://google.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "LastLogin", "Password", "Type", "Username" },
                values: new object[] { 1, new DateTime(2023, 6, 29, 20, 45, 7, 197, DateTimeKind.Local).AddTicks(2047), "1234", 999, "Simon" });

            migrationBuilder.InsertData(
                table: "ProgrammingSkillProject",
                columns: new[] { "ProjectsID", "SkillsID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProjectGalleryImages",
                columns: new[] { "ID", "Alt", "Description", "ProjectID", "Title", "URL" },
                values: new object[] { 1, "A picture of my project", "The first image for our project", 1, "Project image #1", "https://picsum.photos/id/237/300/300" });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingSkillProject_ProjectsID",
                table: "ProgrammingSkillProject",
                column: "ProjectsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgrammingSkillProject",
                table: "ProgrammingSkillProject");

            migrationBuilder.DropIndex(
                name: "IX_ProgrammingSkillProject_ProjectsID",
                table: "ProgrammingSkillProject");

            migrationBuilder.DeleteData(
                table: "ProgrammingSkillProject",
                keyColumns: new[] { "ProjectsID", "SkillsID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProgrammingSkillProject",
                keyColumns: new[] { "ProjectsID", "SkillsID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProgrammingSkillProject",
                keyColumns: new[] { "ProjectsID", "SkillsID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProgrammingSkillProject",
                keyColumns: new[] { "ProjectsID", "SkillsID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProgrammingSkillProject",
                keyColumns: new[] { "ProjectsID", "SkillsID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectGalleryImages",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProgrammingSkills",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProgrammingSkills",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProgrammingSkills",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgrammingSkillProject",
                table: "ProgrammingSkillProject",
                columns: new[] { "ProjectsID", "SkillsID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingSkillProject_SkillsID",
                table: "ProgrammingSkillProject",
                column: "SkillsID");
        }
    }
}
