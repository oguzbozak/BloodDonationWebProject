using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanver.Migrations.GelenRandevu
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RandevuKontrol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false),
                    Konum = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandevuKontrol", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RandevuKontrol");
        }
    }
}
