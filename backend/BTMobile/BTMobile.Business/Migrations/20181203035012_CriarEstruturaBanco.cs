using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BTMobile.Business.Migrations
{
    public partial class CriarEstruturaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contratos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    ProfessorId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fichas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fichas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeriesFicha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RotuloSerie = table.Column<string>(nullable: true),
                    FichaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesFicha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesFicha_Fichas_FichaId",
                        column: x => x.FichaId,
                        principalTable: "Fichas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExerciciosSerie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ordem = table.Column<int>(nullable: false),
                    Repeticao = table.Column<string>(nullable: true),
                    Carga = table.Column<double>(nullable: false),
                    SerieFichaId = table.Column<int>(nullable: true),
                    ExercicioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciciosSerie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciciosSerie_Exercicios_ExercicioId",
                        column: x => x.ExercicioId,
                        principalTable: "Exercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExerciciosSerie_SeriesFicha_SerieFichaId",
                        column: x => x.SerieFichaId,
                        principalTable: "SeriesFicha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoExecucaoSerie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataHoraExecucao = table.Column<DateTime>(nullable: false),
                    SerieFichaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoExecucaoSerie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoExecucaoSerie_SeriesFicha_SerieFichaId",
                        column: x => x.SerieFichaId,
                        principalTable: "SeriesFicha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoAlteracaoCarga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataHoraAlteracao = table.Column<DateTime>(nullable: false),
                    NovaCarga = table.Column<double>(nullable: false),
                    ExercicioSerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoAlteracaoCarga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoAlteracaoCarga_ExerciciosSerie_ExercicioSerieId",
                        column: x => x.ExercicioSerieId,
                        principalTable: "ExerciciosSerie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_ClienteId",
                table: "Contratos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciciosSerie_ExercicioId",
                table: "ExerciciosSerie",
                column: "ExercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciciosSerie_SerieFichaId",
                table: "ExerciciosSerie",
                column: "SerieFichaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_ClienteId",
                table: "Fichas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_ProfessorId",
                table: "Fichas",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoAlteracaoCarga_ExercicioSerieId",
                table: "HistoricoAlteracaoCarga",
                column: "ExercicioSerieId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoExecucaoSerie_SerieFichaId",
                table: "HistoricoExecucaoSerie",
                column: "SerieFichaId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesFicha_FichaId",
                table: "SeriesFicha",
                column: "FichaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "HistoricoAlteracaoCarga");

            migrationBuilder.DropTable(
                name: "HistoricoExecucaoSerie");

            migrationBuilder.DropTable(
                name: "ExerciciosSerie");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "SeriesFicha");

            migrationBuilder.DropTable(
                name: "Fichas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
