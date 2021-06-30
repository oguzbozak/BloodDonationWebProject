using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanver.Migrations
{
    public partial class Araba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Randevulars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir = table.Column<string>(nullable: true),
                    MerkezAdi = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevulars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevulars");
        }
    }
}
