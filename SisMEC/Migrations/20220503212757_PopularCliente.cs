using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class PopularCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes(ClienteNome, ClienteCPF, ClienteEmail, ClienteTelefone, ClienteEndereco) VALUES('Teste', 58995884695, 'teste@gmail.com', 85448599688, 'Rua teste')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clientes");

        }
    }
}
