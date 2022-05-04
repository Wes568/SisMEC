using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class PopularCaixas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Caixa(HoraAbriu, HoraFechou, Saldo, UsuarioId) VALUES('02:50:00', '08:55:00', 50.00, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Caixa");
        }
    }
}
