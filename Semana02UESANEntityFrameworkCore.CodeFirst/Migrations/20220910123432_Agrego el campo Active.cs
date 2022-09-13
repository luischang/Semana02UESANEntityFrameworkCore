using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Semana02UESANEntityFrameworkCore.CodeFirst.Migrations
{
    public partial class AgregoelcampoActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Player",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Player");
        }
    }
}
