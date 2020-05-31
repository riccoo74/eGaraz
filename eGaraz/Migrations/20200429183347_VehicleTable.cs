using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class VehicleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    VinNum = table.Column<string>(nullable: false),
                    EngineCapacity = table.Column<short>(nullable: true),
                    Power = table.Column<short>(nullable: true),
                    OperationalNum = table.Column<string>(nullable: false),
                    Mark = table.Column<string>(nullable: false),
                    Counter = table.Column<int>(nullable: false),
                    YearOfProd = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
