using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class MedicalExaminationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalExaminations",
                columns: table => new
                {
                    MedicalExaminationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FiremenId = table.Column<int>(nullable: true),
                    DriverId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalExaminations", x => x.MedicalExaminationId);
                    table.ForeignKey(
                        name: "FK_MedicalExaminations_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalExaminations_Firemens_FiremenId",
                        column: x => x.FiremenId,
                        principalTable: "Firemens",
                        principalColumn: "FiremanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_DriverId",
                table: "MedicalExaminations",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_FiremenId",
                table: "MedicalExaminations",
                column: "FiremenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalExaminations");
        }
    }
}
