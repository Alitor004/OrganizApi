using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrganizEtec.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Integrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Materia = table.Column<int>(type: "int", nullable: false),
                    Prazo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjetoId = table.Column<int>(type: "int", nullable: false),
                    IntegranteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Temas_Integrantes_IntegranteId",
                        column: x => x.IntegranteId,
                        principalTable: "Integrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Temas_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Integrantes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Alex Vitor" },
                    { 2, "Antonio Mauricio" },
                    { 3, "Breno Lisboa" },
                    { 4, "Gustavo Leite" },
                    { 5, "Rafael Thomas" },
                    { 6, "Vitor Silva" }
                });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "Inicio", "Materia", "Nome", "Prazo" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "RotaLimpa", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Finalização do frontend", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "OrganizEtec", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "React Native", new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Atividade BD", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Temas",
                columns: new[] { "Id", "IntegranteId", "Nome", "ProjetoId" },
                values: new object[,]
                {
                    { 1, 1, "Criar uma pagina a sua ecolha", 2 },
                    { 2, 1, "Finalizar atividade do dia 12/06", 5 },
                    { 3, 1, "Finalizar projeto do da API", 3 },
                    { 4, 1, "Narrativa Caso de Uso 1/2", 1 },
                    { 5, 4, "Narrativa Caso de Uso 2/2", 1 },
                    { 6, 2, "Sprint 03 - Apresentação Diagramas UML 1 1/2", 1 },
                    { 7, 6, "Sprint 03 - Apresentação Diagramas UML 1 2/2", 1 },
                    { 8, 1, "Diagrama de Classe 1/2", 1 },
                    { 9, 4, "Diagrama de Classe 2/2", 1 },
                    { 10, 4, "Modelo Lógico BD 1/2", 1 },
                    { 11, 5, "Modelo Lógico BD 2/2", 1 },
                    { 12, 1, "Scripts BD 1/2", 1 },
                    { 13, 2, "Scripts BD 2/2", 1 },
                    { 14, 2, "Sprint 04 - Apresentação Diagramas UML 1 1/2", 1 },
                    { 15, 6, "Sprint 04 - Apresentação Diagramas UML 1 2/2", 1 },
                    { 16, 3, "Logo da Empresa 1/2", 1 },
                    { 17, 5, "Logo da Empresa 2/2", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Temas_IntegranteId",
                table: "Temas",
                column: "IntegranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Temas_ProjetoId",
                table: "Temas",
                column: "ProjetoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Temas");

            migrationBuilder.DropTable(
                name: "Integrantes");

            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
