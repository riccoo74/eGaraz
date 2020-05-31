using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class ChangedFiremanToFiremen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Firemens_FiremenId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Firemens_FiremenId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "FiremanId",
                table: "Firemens");

            migrationBuilder.AddColumn<int>(
                name: "FiremenId",
                table: "Firemens",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens",
                column: "FiremenId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Firemens_FiremenId",
                table: "AspNetUsers",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremenId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Firemens_FiremenId",
                table: "Drivers",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremenId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremenId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Firemens_FiremenId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Firemens_FiremenId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "FiremenId",
                table: "Firemens");

            migrationBuilder.AddColumn<int>(
                name: "FiremanId",
                table: "Firemens",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens",
                column: "FiremanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Firemens_FiremenId",
                table: "AspNetUsers",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Firemens_FiremenId",
                table: "Drivers",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremanId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
