using Microsoft.EntityFrameworkCore.Migrations;

namespace BarinakTakip.Migrations
{
    public partial class InitialV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Barinak");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "Barinak");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Barinak");

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "Barinak",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Barinak",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Kapasite",
                table: "Barinak",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Il",
                table: "Barinak");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Barinak");

            migrationBuilder.DropColumn(
                name: "Kapasite",
                table: "Barinak");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Barinak",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "Barinak",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Barinak",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
