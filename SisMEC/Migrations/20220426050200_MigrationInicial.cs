using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClienteCPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ClienteEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClienteTelefone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ClienteEndereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProdutoQuantidade = table.Column<decimal>(type: "decimal(10)", nullable: false),
                    ProdutoValor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ProdutoDataValidade = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    ServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicoDataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServicoDataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServicoDescricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServicoValor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ServicoPecas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ServicoObs = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ServicoCompleto = table.Column<bool>(type: "bit", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.ServicoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioLogin = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UsuarioNome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    CarroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarroMarca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarroModelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarroObs = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.CarroId);
                    table.ForeignKey(
                        name: "FK_Carros_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    CaixaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    HoraAbriu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFechou = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.CaixaId);
                    table.ForeignKey(
                        name: "FK_Caixa_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caixa_UsuarioId",
                table: "Caixa",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Carros_ClienteId",
                table: "Carros",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caixa");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
