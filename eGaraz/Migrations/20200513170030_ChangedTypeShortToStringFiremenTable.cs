using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class ChangedTypeShortToStringFiremenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HouseNumber",
                table: "Firemens",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "HouseNumber",
                table: "Firemens",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
