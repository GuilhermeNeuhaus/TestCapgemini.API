using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroPedido.Infra.Migrations
{
    public partial class TabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    CPF = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Celular = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Sexo = table.Column<string>(type: "char", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
