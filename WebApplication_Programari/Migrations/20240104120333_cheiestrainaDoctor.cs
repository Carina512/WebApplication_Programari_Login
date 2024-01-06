using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_Programari.Migrations
{
    public partial class cheiestrainaDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programare_DoctorID",
                table: "Programare",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Doctor_DoctorID",
                table: "Programare",
                column: "DoctorID",
                principalTable: "Doctor",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Doctor_DoctorID",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_DoctorID",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Programare");
        }
    }
}
