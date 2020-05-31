using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class DriverTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FiremenId = table.Column<int>(nullable: true),
                    DrivingLicenseIssueDate = table.Column<DateTime>(nullable: false),
                    DrivingLicenseExpDate = table.Column<DateTime>(nullable: true),
                    DrivingLicenseCategories = table.Column<string>(nullable: false),
                    PermissionExpDate = table.Column<DateTime>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Drivers_Firemens_FiremenId",
                        column: x => x.FiremenId,
                        principalTable: "Firemens",
                        principalColumn: "FiremanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_FiremenId",
                table: "Drivers",
                column: "FiremenId",
                unique: true,
                filter: "[FiremenId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
