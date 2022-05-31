using Microsoft.EntityFrameworkCore.Migrations;

namespace BarinakTakip.Migrations
{
    public partial class InitialV8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "altTur",
                table: "Hayvan");

            migrationBuilder.AddColumn<string>(
                name: "Cins",
                table: "Hayvan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cins",
                table: "Hayvan");

            migrationBuilder.AddColumn<string>(
                name: "altTur",
                table: "Hayvan",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
