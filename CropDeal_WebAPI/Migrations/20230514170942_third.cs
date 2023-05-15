using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropDeal_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crops_Cropdetails_Crop_Details_id",
                table: "Crops");

            migrationBuilder.DropForeignKey(
                name: "FK_Crops_Users_User_id",
                table: "Crops");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Cropdetails_Crop_Details_id",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Users_User_id",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_Crop_Details_id",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_User_id",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Crops_Crop_Details_id",
                table: "Crops");

            migrationBuilder.DropIndex(
                name: "IX_Crops_User_id",
                table: "Crops");

            migrationBuilder.AddColumn<int>(
                name: "CropdetailCrop_Details_id",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CropdetailCrop_Details_id",
                table: "Crops",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "Crops",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CropdetailCrop_Details_id",
                table: "Invoices",
                column: "CropdetailCrop_Details_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_Userid",
                table: "Invoices",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Crops_CropdetailCrop_Details_id",
                table: "Crops",
                column: "CropdetailCrop_Details_id");

            migrationBuilder.CreateIndex(
                name: "IX_Crops_Userid",
                table: "Crops",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Crops_Cropdetails_CropdetailCrop_Details_id",
                table: "Crops",
                column: "CropdetailCrop_Details_id",
                principalTable: "Cropdetails",
                principalColumn: "Crop_Details_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crops_Users_Userid",
                table: "Crops",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Cropdetails_CropdetailCrop_Details_id",
                table: "Invoices",
                column: "CropdetailCrop_Details_id",
                principalTable: "Cropdetails",
                principalColumn: "Crop_Details_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Users_Userid",
                table: "Invoices",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "Userid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crops_Cropdetails_CropdetailCrop_Details_id",
                table: "Crops");

            migrationBuilder.DropForeignKey(
                name: "FK_Crops_Users_Userid",
                table: "Crops");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Cropdetails_CropdetailCrop_Details_id",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Users_Userid",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CropdetailCrop_Details_id",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_Userid",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Crops_CropdetailCrop_Details_id",
                table: "Crops");

            migrationBuilder.DropIndex(
                name: "IX_Crops_Userid",
                table: "Crops");

            migrationBuilder.DropColumn(
                name: "CropdetailCrop_Details_id",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CropdetailCrop_Details_id",
                table: "Crops");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Crops");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_Crop_Details_id",
                table: "Invoices",
                column: "Crop_Details_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_User_id",
                table: "Invoices",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Crops_Crop_Details_id",
                table: "Crops",
                column: "Crop_Details_id");

            migrationBuilder.CreateIndex(
                name: "IX_Crops_User_id",
                table: "Crops",
                column: "User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crops_Cropdetails_Crop_Details_id",
                table: "Crops",
                column: "Crop_Details_id",
                principalTable: "Cropdetails",
                principalColumn: "Crop_Details_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crops_Users_User_id",
                table: "Crops",
                column: "User_id",
                principalTable: "Users",
                principalColumn: "Userid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Cropdetails_Crop_Details_id",
                table: "Invoices",
                column: "Crop_Details_id",
                principalTable: "Cropdetails",
                principalColumn: "Crop_Details_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Users_User_id",
                table: "Invoices",
                column: "User_id",
                principalTable: "Users",
                principalColumn: "Userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
