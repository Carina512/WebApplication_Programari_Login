using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_Programari.Migrations
{
    public partial class DataSiOra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Programare",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipAnimal",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "TipAnimal",
                table: "Programare");
        }
    }
}
