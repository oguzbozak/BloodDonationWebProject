using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanver.Migrations
{
    public partial class Guncel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MerkezAdi",
                table: "Randevulars");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Randevulars");

            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "Randevulars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Konum",
                table: "Randevulars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefon",
                table: "Randevulars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "Randevulars");

            migrationBuilder.DropColumn(
                name: "Konum",
                table: "Randevulars");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Randevulars");

            migrationBuilder.AddColumn<string>(
                name: "MerkezAdi",
                table: "Randevulars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Randevulars",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
