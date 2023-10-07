using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroPedido.Infra.Migrations
{
    public partial class IncluindoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Usuarios",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Telefones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_UsuarioId",
                table: "Telefones",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Usuarios_UsuarioId",
                table: "Telefones",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Usuarios_UsuarioId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_UsuarioId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Telefones");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Usuarios",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");
        }
    }
}
