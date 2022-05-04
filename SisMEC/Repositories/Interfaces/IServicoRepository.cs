using SisMEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories.Interfaces
{
    public interface IServicoRepository
    {
        IEnumerable<Servico> Servicos { get; }
        IEnumerable<Servico> ServicosCompletos { get; }
        IEnumerable<Servico> ServicosIncompletos { get; }
        Servico GetServicoById(int servicoId);
    }
}
