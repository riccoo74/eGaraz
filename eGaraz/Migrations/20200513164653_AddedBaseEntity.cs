using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class AddedBaseEntity : Migration
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
                name: "FK_Equipment_Vehicles_VehicleId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentTrips_Equipment_EquipmentId",
                table: "EquipmentTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentTrips_Trips_TripId",
                table: "EquipmentTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_FiremenTrips_Trips_TripId",
                table: "FiremenTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Drivers_DriverId",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Firemens_FiremenId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTrips_Trips_TripId",
                table: "VehicleTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTrips_Vehicles_VehicleId",
                table: "VehicleTrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trips",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Training",
                table: "Training");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "MedicalExaminationId",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "FiremenId",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "FiremenId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Trips",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Trips",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Training",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Training",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MedicalExaminations",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalExaminations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "MedicalExaminations",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MedicalExaminations",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "MedicalExaminations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "MedicalExaminations",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalExaminations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "MedicalExaminations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Firemens",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Firemens",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Firemens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Firemens",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Firemens",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Firemens",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "Firemens",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Firemens",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Firemens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Equipment",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Equipment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Drivers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Drivers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trips",
                table: "Trips",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Training",
                table: "Training",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CreatedById",
                table: "Vehicles",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DeletedById",
                table: "Vehicles",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UpdatedById",
                table: "Vehicles",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_CreatedById",
                table: "Trips",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DeletedById",
                table: "Trips",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_UpdatedById",
                table: "Trips",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Training_CreatedById",
                table: "Training",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Training_DeletedById",
                table: "Training",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UpdatedById",
                table: "Training",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_CreatedById",
                table: "MedicalExaminations",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_DeletedById",
                table: "MedicalExaminations",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_UpdatedById",
                table: "MedicalExaminations",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Firemens_ApplicationUserId",
                table: "Firemens",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Firemens_CreatedById",
                table: "Firemens",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Firemens_DeletedById",
                table: "Firemens",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Firemens_UpdatedById",
                table: "Firemens",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CreatedById",
                table: "Equipment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_DeletedById",
                table: "Equipment",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UpdatedById",
                table: "Equipment",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_CreatedById",
                table: "Drivers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_DeletedById",
                table: "Drivers",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_UpdatedById",
                table: "Drivers",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_AspNetUsers_CreatedById",
                table: "Drivers",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_AspNetUsers_DeletedById",
                table: "Drivers",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Firemens_FiremenId",
                table: "Drivers",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_AspNetUsers_UpdatedById",
                table: "Drivers",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentTrips_Trips_TripId",
                table: "EquipmentTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Firemens_AspNetUsers_ApplicationUserId",
                table: "Firemens",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Firemens_AspNetUsers_CreatedById",
                table: "Firemens",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Firemens_AspNetUsers_DeletedById",
                table: "Firemens",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Firemens_AspNetUsers_UpdatedById",
                table: "Firemens",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FiremenTrips_Trips_TripId",
                table: "FiremenTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_AspNetUsers_CreatedById",
                table: "MedicalExaminations",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_AspNetUsers_DeletedById",
                table: "MedicalExaminations",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Drivers_DriverId",
                table: "MedicalExaminations",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_AspNetUsers_UpdatedById",
                table: "MedicalExaminations",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_AspNetUsers_CreatedById",
                table: "Training",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_AspNetUsers_DeletedById",
                table: "Training",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Firemens_FiremenId",
                table: "Training",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_AspNetUsers_UpdatedById",
                table: "Training",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_AspNetUsers_CreatedById",
                table: "Trips",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_AspNetUsers_DeletedById",
                table: "Trips",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_AspNetUsers_UpdatedById",
                table: "Trips",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_AspNetUsers_CreatedById",
                table: "Vehicles",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_AspNetUsers_DeletedById",
                table: "Vehicles",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_AspNetUsers_UpdatedById",
                table: "Vehicles",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTrips_Trips_TripId",
                table: "VehicleTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTrips_Vehicles_VehicleId",
                table: "VehicleTrips",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_AspNetUsers_CreatedById",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_AspNetUsers_DeletedById",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Firemens_FiremenId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_AspNetUsers_UpdatedById",
                table: "Drivers");

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

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentTrips_Trips_TripId",
                table: "EquipmentTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_Firemens_AspNetUsers_ApplicationUserId",
                table: "Firemens");

            migrationBuilder.DropForeignKey(
                name: "FK_Firemens_AspNetUsers_CreatedById",
                table: "Firemens");

            migrationBuilder.DropForeignKey(
                name: "FK_Firemens_AspNetUsers_DeletedById",
                table: "Firemens");

            migrationBuilder.DropForeignKey(
                name: "FK_Firemens_AspNetUsers_UpdatedById",
                table: "Firemens");

            migrationBuilder.DropForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_FiremenTrips_Trips_TripId",
                table: "FiremenTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_AspNetUsers_CreatedById",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_AspNetUsers_DeletedById",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Drivers_DriverId",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_AspNetUsers_UpdatedById",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_AspNetUsers_CreatedById",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_AspNetUsers_DeletedById",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Firemens_FiremenId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_AspNetUsers_UpdatedById",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_AspNetUsers_CreatedById",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_AspNetUsers_DeletedById",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_AspNetUsers_UpdatedById",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_AspNetUsers_CreatedById",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_AspNetUsers_DeletedById",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_AspNetUsers_UpdatedById",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTrips_Trips_TripId",
                table: "VehicleTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTrips_Vehicles_VehicleId",
                table: "VehicleTrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CreatedById",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_DeletedById",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_UpdatedById",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trips",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_CreatedById",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_DeletedById",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_UpdatedById",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Training",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_CreatedById",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_DeletedById",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_UpdatedById",
                table: "Training");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations");

            migrationBuilder.DropIndex(
                name: "IX_MedicalExaminations_CreatedById",
                table: "MedicalExaminations");

            migrationBuilder.DropIndex(
                name: "IX_MedicalExaminations_DeletedById",
                table: "MedicalExaminations");

            migrationBuilder.DropIndex(
                name: "IX_MedicalExaminations_UpdatedById",
                table: "MedicalExaminations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens");

            migrationBuilder.DropIndex(
                name: "IX_Firemens_ApplicationUserId",
                table: "Firemens");

            migrationBuilder.DropIndex(
                name: "IX_Firemens_CreatedById",
                table: "Firemens");

            migrationBuilder.DropIndex(
                name: "IX_Firemens_DeletedById",
                table: "Firemens");

            migrationBuilder.DropIndex(
                name: "IX_Firemens_UpdatedById",
                table: "Firemens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_CreatedById",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_DeletedById",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_UpdatedById",
                table: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_CreatedById",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_DeletedById",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_UpdatedById",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Firemens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Drivers");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "Training",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MedicalExaminationId",
                table: "MedicalExaminations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FiremenId",
                table: "Firemens",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FiremenId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trips",
                table: "Trips",
                column: "TripId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Training",
                table: "Training",
                column: "TrainingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations",
                column: "MedicalExaminationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Firemens",
                table: "Firemens",
                column: "FiremenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FiremenId",
                table: "AspNetUsers",
                column: "FiremenId",
                unique: true,
                filter: "[FiremenId] IS NOT NULL");

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
                name: "FK_Equipment_Vehicles_VehicleId",
                table: "Equipment",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentTrips_Equipment_EquipmentId",
                table: "EquipmentTrips",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentTrips_Trips_TripId",
                table: "EquipmentTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FiremenTrips_Firemens_FiremenId",
                table: "FiremenTrips",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FiremenTrips_Trips_TripId",
                table: "FiremenTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Drivers_DriverId",
                table: "MedicalExaminations",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Firemens_FiremenId",
                table: "MedicalExaminations",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremenId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Firemens_FiremenId",
                table: "Training",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "FiremenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTrips_Trips_TripId",
                table: "VehicleTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTrips_Vehicles_VehicleId",
                table: "VehicleTrips",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
