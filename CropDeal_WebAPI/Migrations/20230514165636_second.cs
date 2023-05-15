using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropDeal_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cropdetails");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Invoices",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Cropdetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
