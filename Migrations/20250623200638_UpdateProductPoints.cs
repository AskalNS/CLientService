using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClientService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductPoints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MerchantProductCode = table.Column<string>(type: "text", nullable: false),
                    LoanPeriod = table.Column<int>(type: "integer", nullable: false),
                    CityCode = table.Column<string>(type: "text", nullable: false),
                    CityName = table.Column<string>(type: "text", nullable: false),
                    CityNameRu = table.Column<string>(type: "text", nullable: false),
                    PointCode = table.Column<string>(type: "text", nullable: false),
                    PointName = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPoints", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPoints_MerchantProductCode_CityCode_PointCode",
                table: "ProductPoints",
                columns: new[] { "MerchantProductCode", "CityCode", "PointCode" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPoints");
        }
    }
}
