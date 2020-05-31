using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class AddedRelationsTableFiremenTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Firemens_AspNetUsers_ApplicationUserId",
                table: "Firemens");

            migrationBuilder.DropIndex(
                name: "IX_Firemens_ApplicationUserId",
                table: "Firemens");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Firemens");

            migrationBuilder.CreateTable(
                name: "FiremenTrips",
                columns: table => new
                {
                    FiremenId = table.Column<int>(nullable: false),
                    TripId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiremenTrips", x => new { x.FiremenId, x.TripId });
                    table.ForeignKey(
                        name: "FK_FiremenTrips_Firemens_FiremenId",
                        column: x => x.FiremenId,
                        principalTable: "Firemens",
                        principalColumn: "FiremanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FiremenTrips_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers",
                column: "FiremenId",
                unique: true,
                filter: "[FiremenId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FiremenTrips_TripId",
                table: "FiremenTrips",
                column: "TripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FiremenTrips");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Firemens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Firemens_ApplicationUserId",
                table: "Firemens",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers",
                column: "FiremenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Firemens_AspNetUsers_ApplicationUserId",
                table: "Firemens",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
