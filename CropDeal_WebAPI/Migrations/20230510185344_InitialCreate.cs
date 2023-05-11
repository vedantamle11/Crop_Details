using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropDeal_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Admin_id);
                });

            migrationBuilder.CreateTable(
                name: "CropDetails",
                columns: table => new
                {
                    Crop_Details_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crop_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crop_Details_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crop_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CropDetails", x => x.Crop_Details_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    User_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Roles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Suscribed = table.Column<bool>(type: "bit", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "BankInformation",
                columns: table => new
                {
                    BankDetail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bank_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank_Account_No = table.Column<int>(type: "int", nullable: false),
                    IFSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInformation", x => x.BankDetail_id);
                    table.ForeignKey(
                        name: "FK_BankInformation_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CropDisplays",
                columns: table => new
                {
                    Crop_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crop_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crop_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Crop_Details_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CropDisplays", x => x.Crop_id);
                    table.ForeignKey(
                        name: "FK_CropDisplays_CropDetails_Crop_Details_Id",
                        column: x => x.Crop_Details_Id,
                        principalTable: "CropDetails",
                        principalColumn: "Crop_Details_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CropDisplays_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Invoice_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Payment_Mode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Crop_Details_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Invoice_id);
                    table.ForeignKey(
                        name: "FK_Invoices_CropDetails_Crop_Details_Id",
                        column: x => x.Crop_Details_Id,
                        principalTable: "CropDetails",
                        principalColumn: "Crop_Details_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankInformation_User_Id",
                table: "BankInformation",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CropDisplays_Crop_Details_Id",
                table: "CropDisplays",
                column: "Crop_Details_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CropDisplays_User_Id",
                table: "CropDisplays",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_Crop_Details_Id",
                table: "Invoices",
                column: "Crop_Details_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_User_Id",
                table: "Invoices",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "BankInformation");

            migrationBuilder.DropTable(
                name: "CropDisplays");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "CropDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
