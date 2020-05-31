using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class FiremenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FiremenId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Firemens",
                columns: table => new
                {
                    FiremanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Pesel = table.Column<string>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Son_Daughter = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    HouseNumber = table.Column<short>(nullable: false),
                    FlatNumber = table.Column<short>(nullable: true),
                    DigitalCode = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Function = table.Column<string>(nullable: false),
                    Management = table.Column<bool>(nullable: false),
                    Driver = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firemens", x => x.FiremanId);
                    table.ForeignKey(
                        name: "FK_Firemens_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers",
                column: "FiremenId");

            migrationBuilder.CreateIndex(
                name: "IX_Firemens_ApplicationUserId",
                table: "Firemens",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Firemens_FiremenId",
                table: "AspNetUsers",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Firemens_FiremenId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Firemens");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FiremenId",
                table: "AspNetUsers");
        }
    }
}
