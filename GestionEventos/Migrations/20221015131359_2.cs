using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionEventos.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Eventos",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Eventos",
                newName: "descripcion");

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "Eventos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asistentes",
                columns: table => new
                {
                    eventoId = table.Column<int>(type: "int", nullable: false),
                    personaId = table.Column<int>(type: "int", nullable: false),
                    respuesta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistentes", x => new { x.eventoId, x.personaId });
                    table.ForeignKey(
                        name: "FK_Asistentes_Eventos_eventoId",
                        column: x => x.eventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistentes_Personas_personaId",
                        column: x => x.personaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistentes_personaId",
                table: "Asistentes",
                column: "personaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistentes");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Eventos",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Eventos",
                newName: "Descripcion");
        }
    }
}
