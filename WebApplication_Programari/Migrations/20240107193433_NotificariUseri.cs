using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_Programari.Migrations
{
    public partial class NotificariUseri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Doctor_DoctorID",
                table: "Programare");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Programare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notificareid",
                table: "Programare",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Notificare",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificare", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizatori",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizatori", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programare_Notificareid",
                table: "Programare",
                column: "Notificareid");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Doctor_DoctorID",
                table: "Programare",
                column: "DoctorID",
                principalTable: "Doctor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Notificare_Notificareid",
                table: "Programare",
                column: "Notificareid",
                principalTable: "Notificare",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Doctor_DoctorID",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Notificare_Notificareid",
                table: "Programare");

            migrationBuilder.DropTable(
                name: "Notificare");

            migrationBuilder.DropTable(
                name: "Utilizatori");

            migrationBuilder.DropIndex(
                name: "IX_Programare_Notificareid",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "Notificareid",
                table: "Programare");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "Programare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Programare",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Doctor_DoctorID",
                table: "Programare",
                column: "DoctorID",
                principalTable: "Doctor",
                principalColumn: "ID");
        }
    }
}
