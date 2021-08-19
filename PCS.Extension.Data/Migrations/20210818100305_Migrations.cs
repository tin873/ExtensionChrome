using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCS.Extension.Data.Migrations
{
    public partial class Migrations : Migration
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
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(nullable: true),
                    CurrencyCode = table.Column<string>(nullable: true),
                    ExchangeRate = table.Column<decimal>(nullable: false),
                    GetDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReponseDataDbSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    ProductTitle = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ProductImageSrc = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    GetDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    IdPage = table.Column<int>(nullable: false),
                    IdCurrency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReponseDataDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourcePages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourcePages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appconfigs");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "ReponseDataDbSet");

            migrationBuilder.DropTable(
                name: "SourcePages");
        }
    }
}
