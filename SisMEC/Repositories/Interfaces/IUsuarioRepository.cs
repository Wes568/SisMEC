using SisMEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> Usuarios { get; }
        Usuario GetUsuarioById(int usuarioId);
    }
}
