using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class AddedBaseEntityToEquipmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_AspNetUsers_CreatedById",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_AspNetUsers_DeletedById",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_AspNetUsers_UpdatedById",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Vehicles_VehicleId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentTrips_Equipment_EquipmentId",
                table: "EquipmentTrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "Equipments");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_VehicleId",
                table: "Equipments",
                newName: "IX_Equipments_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_UpdatedById",
                table: "Equipments",
                newName: "IX_Equipments_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_DeletedById",
                table: "Equipments",
                newName: "IX_Equipments_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_CreatedById",
                table: "Equipments",
                newName: "IX_Equipments_CreatedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_AspNetUsers_CreatedById",
                table: "Equipments",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_AspNetUsers_DeletedById",
                table: "Equipments",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_AspNetUsers_UpdatedById",
                table: "Equipments",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Vehicles_VehicleId",
                table: "Equipments",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentTrips_Equipments_EquipmentId",
                table: "EquipmentTrips",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_AspNetUsers_CreatedById",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_AspNetUsers_DeletedById",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_AspNetUsers_UpdatedById",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Vehicles_VehicleId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentTrips_Equipments_EquipmentId",
                table: "EquipmentTrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments");

            migrationBuilder.RenameTable(
                name: "Equipments",
                newName: "Equipment");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_VehicleId",
                table: "Equipment",
                newName: "IX_Equipment_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_UpdatedById",
                table: "Equipment",
                newName: "IX_Equipment_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_DeletedById",
                table: "Equipment",
                newName: "IX_Equipment_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_CreatedById",
                table: "Equipment",
                newName: "IX_Equipment_CreatedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_AspNetUsers_CreatedById",
                table: "Equipment",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_AspNetUsers_DeletedById",
                table: "Equipment",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_AspNetUsers_UpdatedById",
                table: "Equipment",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Vehicles_VehicleId",
                table: "Equipment",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentTrips_Equipment_EquipmentId",
                table: "EquipmentTrips",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
