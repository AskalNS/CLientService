using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Codes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    CodeValue = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HalykCredentials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    EncriptPassword = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HalykCredentials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntegratedUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxPersent = table.Column<double>(type: "double precision", nullable: false),
                    TimeFlag = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsWorking = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratedUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    HashPassword = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    MerchantProductCode = table.Column<string>(type: "text", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    ActualPrice = table.Column<double>(type: "double precision", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Remains = table.Column<int>(type: "integer", nullable: false),
                    IsDump = table.Column<bool>(type: "boolean", nullable: false),
                    MaxPrice = table.Column<double>(type: "double precision", nullable: false),
                    MinPrice = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Codes");

            migrationBuilder.DropTable(
                name: "HalykCredentials");

            migrationBuilder.DropTable(
                name: "IntegratedUsers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserSettings");
        }
    }
}
