using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropDeal_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class now : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bankdetails_Users_User_id",
                table: "Bankdetails");

            migrationBuilder.DropIndex(
                name: "IX_Bankdetails_User_id",
                table: "Bankdetails");

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "Bankdetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bankdetails_Userid",
                table: "Bankdetails",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Bankdetails_Users_Userid",
                table: "Bankdetails",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "Userid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bankdetails_Users_Userid",
                table: "Bankdetails");

            migrationBuilder.DropIndex(
                name: "IX_Bankdetails_Userid",
                table: "Bankdetails");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Bankdetails");

            migrationBuilder.CreateIndex(
                name: "IX_Bankdetails_User_id",
                table: "Bankdetails",
                column: "User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bankdetails_Users_User_id",
                table: "Bankdetails",
                column: "User_id",
                principalTable: "Users",
                principalColumn: "Userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
