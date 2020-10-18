﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace UdemyNLayerProject.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false),
                    InnerBarcode = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 1, "Kalemler", false },
                    { 2, "Defterler", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "InnerBarcode", "Name", "Price", "Stock", "isDeleted" },
                values: new object[,]
                {
                    { 1, 1, null, "Pilot Kalem", 12.50m, 100, false },
                    { 2, 1, null, "Kurşun Kalem", 40.50m, 200, false },
                    { 3, 1, null, "Tükenmez Kalem", 500m, 300, false },
                    { 4, 2, null, "Küçük Boy Defter", 12.50m, 100, false },
                    { 5, 2, null, "Orta Boy Defter", 12.50m, 100, false },
                    { 6, 2, null, "Büyük Boy Defter", 12.50m, 100, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
