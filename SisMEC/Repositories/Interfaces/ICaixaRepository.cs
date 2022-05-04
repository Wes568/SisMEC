using SisMEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories.Interfaces
{
    public interface ICaixaRepository
    {
        IEnumerable<Caixa> Caixas { get; }
        Caixa GetCaixaById(int caixaId);
    }
}
