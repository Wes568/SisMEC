using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class PopularServicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Servicos(ServicoDataEntrada, ServicoDataSaida, ServicoDescricao, ServicoValor, ServicoPecas, ServicoObs, ServicoCompleto, ClienteId) VALUES('01/05/2022', '', 'Carro quebrado', 200.00, 'Carburador', 'Carro muito velho',0, 1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Servicos");

        }

    }
}
