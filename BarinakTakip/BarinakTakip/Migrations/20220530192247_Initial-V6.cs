using Microsoft.EntityFrameworkCore.Migrations;

namespace BarinakTakip.Migrations
{
    public partial class InitialV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarinakId",
                table: "Hayvan",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarinakId",
                table: "Hayvan");
        }
    }
}
