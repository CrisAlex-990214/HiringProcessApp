using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HiringProcess.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Evaluators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluators_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Postulations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    SalaryAspiration = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    CandidateId = table.Column<int>(nullable: false),
                    EvaluatorId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postulations_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Postulations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Postulations_Evaluators_EvaluatorId",
                        column: x => x.EvaluatorId,
                        principalTable: "Evaluators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Postulations_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FinalSteps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvgScore = table.Column<double>(nullable: false),
                    AgreedSalary = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    PostulationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalSteps_Postulations_PostulationId",
                        column: x => x.PostulationId,
                        principalTable: "Postulations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    QualId = table.Column<int>(nullable: false),
                    PostulationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Postulations_PostulationId",
                        column: x => x.PostulationId,
                        principalTable: "Postulations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tests_Quals_QualId",
                        column: x => x.QualId,
                        principalTable: "Quals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Devco" });

            migrationBuilder.InsertData(
                table: "Quals",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Theoretical" },
                    { 2, "Technical" },
                    { 3, "Psychological" },
                    { 4, "Medical" }
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Cristian Duque" },
                    { 2, 1, "Valeria Moreno" },
                    { 3, 1, "Pablo Perez" }
                });

            migrationBuilder.InsertData(
                table: "Evaluators",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Natalia Torres" },
                    { 2, 1, "Paula Dorado" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Development engineer" },
                    { 2, 1, "QA Automation engineer" }
                });

            migrationBuilder.InsertData(
                table: "Postulations",
                columns: new[] { "Id", "CandidateId", "CompanyId", "Date", "EvaluatorId", "RoleId", "SalaryAspiration" },
                values: new object[] { 1, 1, 1, new DateTime(2021, 10, 15, 20, 3, 29, 697, DateTimeKind.Local).AddTicks(5950), 1, 1, 5500000 });

            migrationBuilder.InsertData(
                table: "Postulations",
                columns: new[] { "Id", "CandidateId", "CompanyId", "Date", "EvaluatorId", "RoleId", "SalaryAspiration" },
                values: new object[] { 3, 3, 1, new DateTime(2021, 10, 15, 20, 3, 29, 698, DateTimeKind.Local).AddTicks(3360), 1, 1, 4500000 });

            migrationBuilder.InsertData(
                table: "Postulations",
                columns: new[] { "Id", "CandidateId", "CompanyId", "Date", "EvaluatorId", "RoleId", "SalaryAspiration" },
                values: new object[] { 2, 2, 1, new DateTime(2021, 10, 15, 20, 3, 29, 698, DateTimeKind.Local).AddTicks(3284), 2, 2, 5000000 });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_CompanyId",
                table: "Candidates",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluators_CompanyId",
                table: "Evaluators",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalSteps_PostulationId",
                table: "FinalSteps",
                column: "PostulationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Postulations_CandidateId",
                table: "Postulations",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulations_CompanyId",
                table: "Postulations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulations_EvaluatorId",
                table: "Postulations",
                column: "EvaluatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulations_RoleId",
                table: "Postulations",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CompanyId",
                table: "Roles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_PostulationId",
                table: "Tests",
                column: "PostulationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_QualId",
                table: "Tests",
                column: "QualId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinalSteps");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Postulations");

            migrationBuilder.DropTable(
                name: "Quals");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Evaluators");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
