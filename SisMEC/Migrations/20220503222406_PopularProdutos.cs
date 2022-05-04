using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class PopularProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(ProdutoNome, ProdutoQuantidade, ProdutoValor, ProdutoDataValidade) VALUES('Oleo 500ml', 50, 50.00, '12/05/2030')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
