using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionEventos.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Discriminator", "contrasenia", "correo", "nombre" },
                values: new object[] { 1, "Usuario", "qwerty", "omontero123@gmail.com", "osvaldo" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Discriminator", "contrasenia", "correo", "nombre" },
                values: new object[] { 2, "Usuario", "qwerty", "omontero123@hotmail.com", "segundo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
