using Microsoft.EntityFrameworkCore.Migrations;

namespace BTMobile.Business.Migrations
{
    public partial class CriacaoDeCamposParaForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Clientes_ClienteId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciciosSerie_Exercicios_ExercicioId",
                table: "ExerciciosSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciciosSerie_SeriesFicha_SerieFichaId",
                table: "ExerciciosSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_Fichas_Clientes_ClienteId",
                table: "Fichas");

            migrationBuilder.DropForeignKey(
                name: "FK_Fichas_Professores_ProfessorId",
                table: "Fichas");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoAlteracaoCarga_ExerciciosSerie_ExercicioSerieId",
                table: "HistoricoAlteracaoCarga");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoExecucaoSerie_SeriesFicha_SerieFichaId",
                table: "HistoricoExecucaoSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesFicha_Fichas_FichaId",
                table: "SeriesFicha");

            migrationBuilder.AlterColumn<int>(
                name: "FichaId",
                table: "SeriesFicha",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SerieFichaId",
                table: "HistoricoExecucaoSerie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExercicioSerieId",
                table: "HistoricoAlteracaoCarga",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Fichas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Fichas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SerieFichaId",
                table: "ExerciciosSerie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExercicioId",
                table: "ExerciciosSerie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Contratos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Clientes_ClienteId",
                table: "Contratos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciciosSerie_Exercicios_ExercicioId",
                table: "ExerciciosSerie",
                column: "ExercicioId",
                principalTable: "Exercicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciciosSerie_SeriesFicha_SerieFichaId",
                table: "ExerciciosSerie",
                column: "SerieFichaId",
                principalTable: "SeriesFicha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fichas_Clientes_ClienteId",
                table: "Fichas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fichas_Professores_ProfessorId",
                table: "Fichas",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoAlteracaoCarga_ExerciciosSerie_ExercicioSerieId",
                table: "HistoricoAlteracaoCarga",
                column: "ExercicioSerieId",
                principalTable: "ExerciciosSerie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoExecucaoSerie_SeriesFicha_SerieFichaId",
                table: "HistoricoExecucaoSerie",
                column: "SerieFichaId",
                principalTable: "SeriesFicha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesFicha_Fichas_FichaId",
                table: "SeriesFicha",
                column: "FichaId",
                principalTable: "Fichas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Clientes_ClienteId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciciosSerie_Exercicios_ExercicioId",
                table: "ExerciciosSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciciosSerie_SeriesFicha_SerieFichaId",
                table: "ExerciciosSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_Fichas_Clientes_ClienteId",
                table: "Fichas");

            migrationBuilder.DropForeignKey(
                name: "FK_Fichas_Professores_ProfessorId",
                table: "Fichas");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoAlteracaoCarga_ExerciciosSerie_ExercicioSerieId",
                table: "HistoricoAlteracaoCarga");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoExecucaoSerie_SeriesFicha_SerieFichaId",
                table: "HistoricoExecucaoSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesFicha_Fichas_FichaId",
                table: "SeriesFicha");

            migrationBuilder.AlterColumn<int>(
                name: "FichaId",
                table: "SeriesFicha",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SerieFichaId",
                table: "HistoricoExecucaoSerie",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ExercicioSerieId",
                table: "HistoricoAlteracaoCarga",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Fichas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Fichas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SerieFichaId",
                table: "ExerciciosSerie",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ExercicioId",
                table: "ExerciciosSerie",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Contratos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Clientes_ClienteId",
                table: "Contratos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciciosSerie_Exercicios_ExercicioId",
                table: "ExerciciosSerie",
                column: "ExercicioId",
                principalTable: "Exercicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciciosSerie_SeriesFicha_SerieFichaId",
                table: "ExerciciosSerie",
                column: "SerieFichaId",
                principalTable: "SeriesFicha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fichas_Clientes_ClienteId",
                table: "Fichas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fichas_Professores_ProfessorId",
                table: "Fichas",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoAlteracaoCarga_ExerciciosSerie_ExercicioSerieId",
                table: "HistoricoAlteracaoCarga",
                column: "ExercicioSerieId",
                principalTable: "ExerciciosSerie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoExecucaoSerie_SeriesFicha_SerieFichaId",
                table: "HistoricoExecucaoSerie",
                column: "SerieFichaId",
                principalTable: "SeriesFicha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesFicha_Fichas_FichaId",
                table: "SeriesFicha",
                column: "FichaId",
                principalTable: "Fichas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
