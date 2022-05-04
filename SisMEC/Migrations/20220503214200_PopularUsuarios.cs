using Microsoft.EntityFrameworkCore.Migrations;

namespace SisMEC.Migrations
{
    public partial class PopularUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios(UsuarioLogin, UsuarioSenha, UsuarioEmail, UsuarioNome) VALUES('Adiel2002', 'Adielzinho', 'adiel@gmail.com', 'Adiel')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Usuarios");
        }
    }
}
