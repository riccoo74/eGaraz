using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class AddedSomePropertiesToTripTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Trips",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DigitalCode",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyNum",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Trips",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "DigitalCode",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "PropertyNum",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Trips");
        }
    }
}
