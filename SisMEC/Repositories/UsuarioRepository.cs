using SisMEC.Context;
using SisMEC.Models;
using SisMEC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> Usuarios => _context.Usuarios;

        public Usuario GetUsuarioById(int usuarioId)
        {
            return _context.Usuarios.FirstOrDefault(l => l.UsuarioId == usuarioId);
        }
    }
}
