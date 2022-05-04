using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class PopularClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes(ClienteNome, ClienteCPF, ClienteEmail, ClienteTelefone, ClienteEndereco, CarroId) VALUES('Teste', 58995884695, 'teste@gmail.com', 85448599688, 'Rua teste', 1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clientes");

        }
    }
}
