using Microsoft.EntityFrameworkCore;
using SisMEC.Context;
using SisMEC.Models;
using SisMEC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly AppDbContext _context;

        public ServicoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Servico> Servicos => _context.Servicos;

        public IEnumerable<Servico> ServicosCompletos => _context.Servicos.
                                   Where(s => s.ServicoCompleto == true);

        public IEnumerable<Servico> ServicosIncompletos => _context.Servicos.
                           Where(s => s.ServicoCompleto == false);

        public Servico GetServicoById(int servicoId)
        {
            return _context.Servicos.FirstOrDefault(l => l.ServicoId == servicoId);
        }
    }
}
