using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gerenciador_de_espaçonaves_do_star_wars.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Naves",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naves", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Planetas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planetas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pilotos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    PlanetaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pilotos_Planetas_PlanetaID",
                        column: x => x.PlanetaID,
                        principalTable: "Planetas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoViagens",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pilotoid = table.Column<int>(nullable: false),
                    Naveid = table.Column<int>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: false),
                    DataChegada = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoViagens", x => x.id);
                    table.ForeignKey(
                        name: "FK_HistoricoViagens_Naves_Naveid",
                        column: x => x.Naveid,
                        principalTable: "Naves",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricoViagens_Pilotos_Pilotoid",
                        column: x => x.Pilotoid,
                        principalTable: "Pilotos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoViagens_Naveid",
                table: "HistoricoViagens",
                column: "Naveid");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoViagens_Pilotoid",
                table: "HistoricoViagens",
                column: "Pilotoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pilotos_PlanetaID",
                table: "Pilotos",
                column: "PlanetaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoViagens");

            migrationBuilder.DropTable(
                name: "Naves");

            migrationBuilder.DropTable(
                name: "Pilotos");

            migrationBuilder.DropTable(
                name: "Planetas");
        }
    }
}
