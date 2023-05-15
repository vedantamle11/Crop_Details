using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropDeal_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
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
                name: "Cropdetails",
                columns: table => new
                {
                    Crop_Details_id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Cropdetails", x => x.Crop_Details_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserEmail_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UserContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRoles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Suscribed = table.Column<bool>(type: "bit", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Userid);
                });

            migrationBuilder.CreateTable(
                name: "Bankdetails",
                columns: table => new
                {
                    BankDetail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bank_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank_Account_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IFSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bankdetails", x => x.BankDetail_id);
                    table.ForeignKey(
                        name: "FK_Bankdetails_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Crop_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crop_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crop_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Crop_Details_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Crop_id);
                    table.ForeignKey(
                        name: "FK_Crops_Cropdetails_Crop_Details_id",
                        column: x => x.Crop_Details_id,
                        principalTable: "Cropdetails",
                        principalColumn: "Crop_Details_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Crops_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Userid",
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
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Crop_Details_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Invoice_id);
                    table.ForeignKey(
                        name: "FK_Invoices_Cropdetails_Crop_Details_id",
                        column: x => x.Crop_Details_id,
                        principalTable: "Cropdetails",
                        principalColumn: "Crop_Details_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bankdetails_User_id",
                table: "Bankdetails",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Crops_Crop_Details_id",
                table: "Crops",
                column: "Crop_Details_id");

            migrationBuilder.CreateIndex(
                name: "IX_Crops_User_id",
                table: "Crops",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_Crop_Details_id",
                table: "Invoices",
                column: "Crop_Details_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_User_id",
                table: "Invoices",
                column: "User_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Bankdetails");

            migrationBuilder.DropTable(
                name: "Crops");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Cropdetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
