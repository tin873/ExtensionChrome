using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCS.Extension.Data.Migrations
{
    public partial class ExtensionMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appconfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appconfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ClientCards",
                columns: table => new
                {
                    ClientCardId = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCards", x => x.ClientCardId);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurencyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(nullable: true),
                    CurrencyCode = table.Column<string>(nullable: true),
                    ExchangeRate = table.Column<decimal>(nullable: false),
                    GetDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurencyId);
                });

            migrationBuilder.CreateTable(
                name: "SourcePages",
                columns: table => new
                {
                    SourcePageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourcePages", x => x.SourcePageId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTitle = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ProductImageSrc = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    LastPrice = table.Column<decimal>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    SourcePageId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    ClientCardId = table.Column<string>(nullable: true),
                    ClientCardId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ClientCards_ClientCardId1",
                        column: x => x.ClientCardId1,
                        principalTable: "ClientCards",
                        principalColumn: "ClientCardId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "CurencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SourcePages_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePages",
                        principalColumn: "SourcePageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClientCardId1",
                table: "Products",
                column: "ClientCardId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CurrencyId",
                table: "Products",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SourcePageId",
                table: "Products",
                column: "SourcePageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appconfigs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ClientCards");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "SourcePages");
        }
    }
}
