using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<float>(type: "real", nullable: false),
                    yearsOfExperience = table.Column<int>(type: "int", nullable: false),
                    hiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "priority",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priority", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "severity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_severity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bugs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creatorId = table.Column<int>(type: "int", nullable: false),
                    priorityId = table.Column<int>(type: "int", nullable: false),
                    severityId = table.Column<int>(type: "int", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    solved = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bugs", x => x.id);
                    table.ForeignKey(
                        name: "FK_bugs_person_creatorId",
                        column: x => x.creatorId,
                        principalTable: "person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bugs_priority_priorityId",
                        column: x => x.priorityId,
                        principalTable: "priority",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bugs_severity_severityId",
                        column: x => x.severityId,
                        principalTable: "severity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bugId = table.Column<int>(type: "int", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs", x => x.id);
                    table.ForeignKey(
                        name: "FK_logs_bugs_bugId",
                        column: x => x.bugId,
                        principalTable: "bugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bugId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    personId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_messages_bugs_bugId",
                        column: x => x.bugId,
                        principalTable: "bugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_messages_person_personId",
                        column: x => x.personId,
                        principalTable: "person",
                        principalColumn: "id");
                       // onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bugs_creatorId",
                table: "bugs",
                column: "creatorId");

            migrationBuilder.CreateIndex(
                name: "IX_bugs_priorityId",
                table: "bugs",
                column: "priorityId");

            migrationBuilder.CreateIndex(
                name: "IX_bugs_severityId",
                table: "bugs",
                column: "severityId");

            migrationBuilder.CreateIndex(
                name: "IX_logs_bugId",
                table: "logs",
                column: "bugId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_bugId",
                table: "messages",
                column: "bugId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_personId",
                table: "messages",
                column: "personId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logs");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "bugs");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "priority");

            migrationBuilder.DropTable(
                name: "severity");
        }
    }
}
