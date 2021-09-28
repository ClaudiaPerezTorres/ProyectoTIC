using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsigOficinas.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnostico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sintomas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaDiagnostico = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostico", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Gobernacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gobernacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sistema",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistema", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gobernacionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sede_Gobernacion_Gobernacionid",
                        column: x => x.Gobernacionid,
                        principalTable: "Gobernacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Oficina",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aforo = table.Column<int>(type: "int", nullable: false),
                    horaLaboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoOficina = table.Column<bool>(type: "bit", nullable: false),
                    Sedeid = table.Column<int>(type: "int", nullable: true),
                    Sistemaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficina", x => x.id);
                    table.ForeignKey(
                        name: "FK_Oficina_Sede_Sedeid",
                        column: x => x.Sedeid,
                        principalTable: "Sede",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oficina_Sistema_Sistemaid",
                        column: x => x.Sistemaid,
                        principalTable: "Sistema",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<long>(type: "bigint", nullable: false),
                    edad = table.Column<byte>(type: "tinyint", nullable: false),
                    estadoCovid = table.Column<bool>(type: "bit", nullable: false),
                    diagnosticoid = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oficinaid = table.Column<int>(type: "int", nullable: true),
                    oficinasVisitadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turnoDesarrolloServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servicioRealizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    undDesarrolloServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    despacho = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                    table.ForeignKey(
                        name: "FK_Persona_Diagnostico_diagnosticoid",
                        column: x => x.diagnosticoid,
                        principalTable: "Diagnostico",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Oficina_Oficinaid",
                        column: x => x.Oficinaid,
                        principalTable: "Oficina",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_Sedeid",
                table: "Oficina",
                column: "Sedeid");

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_Sistemaid",
                table: "Oficina",
                column: "Sistemaid");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_diagnosticoid",
                table: "Persona",
                column: "diagnosticoid");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Oficinaid",
                table: "Persona",
                column: "Oficinaid");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Gobernacionid",
                table: "Sede",
                column: "Gobernacionid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Registro");

            migrationBuilder.DropTable(
                name: "Diagnostico");

            migrationBuilder.DropTable(
                name: "Oficina");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Sistema");

            migrationBuilder.DropTable(
                name: "Gobernacion");
        }
    }
}
