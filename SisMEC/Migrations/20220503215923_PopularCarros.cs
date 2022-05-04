using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class PopularCarros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Carros(CarroMarca, CarroModelo, CarroObs) VALUES('Fiat', '147', 'adiel@gmail.com', 'Traseira restaurada')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Carros");
        }
    }
}
