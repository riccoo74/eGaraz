using Microsoft.EntityFrameworkCore.Migrations;

namespace eGaraz.Migrations
{
    public partial class ChangedTableNameTrainingToTrainings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Training",
                table: "Training");

            migrationBuilder.RenameTable(
                name: "Training",
                newName: "Trainings");

            migrationBuilder.RenameIndex(
                name: "IX_Training_UpdatedById",
                table: "Trainings",
                newName: "IX_Trainings_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Training_FiremenId",
                table: "Trainings",
                newName: "IX_Trainings_FiremenId");

            migrationBuilder.RenameIndex(
                name: "IX_Training_DeletedById",
                table: "Trainings",
                newName: "IX_Trainings_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_Training_CreatedById",
                table: "Trainings",
                newName: "IX_Trainings_CreatedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainings",
                table: "Trainings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_AspNetUsers_CreatedById",
                table: "Trainings",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_AspNetUsers_DeletedById",
                table: "Trainings",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Firemens_FiremenId",
                table: "Trainings",
                column: "FiremenId",
                principalTable: "Firemens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_AspNetUsers_UpdatedById",
                table: "Trainings",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_AspNetUsers_CreatedById",
                table: "Trainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_AspNetUsers_DeletedById",
                table: "Trainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Firemens_FiremenId",
                table: "Trainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_AspNetUsers_UpdatedById",
                table: "Trainings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainings",
                table: "Trainings");

            migrationBuilder.RenameTable(
                name: "Trainings",
                newName: "Training");

            migrationBuilder.RenameIndex(
                name: "IX_Trainings_UpdatedById",
                table: "Training",
                newName: "IX_Training_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Trainings_FiremenId",
                table: "Training",
                newName: "IX_Training_FiremenId");

            migrationBuilder.RenameIndex(
                name: "IX_Trainings_DeletedById",
                table: "Training",
                newName: "IX_Training_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_Trainings_CreatedById",
                table: "Training",
                newName: "IX_Training_CreatedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Training",
                table: "Training",
                column: "Id");

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
        }
    }
}
