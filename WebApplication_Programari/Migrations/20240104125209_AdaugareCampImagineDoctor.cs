using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_Programari.Migrations
{
    public partial class AdaugareCampImagineDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Doctor");
        }
    }
}
