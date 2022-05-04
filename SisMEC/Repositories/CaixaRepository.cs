using SisMEC.Context;
using SisMEC.Models;
using SisMEC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories
{
    public class CaixaRepository : ICaixaRepository
    {
        private readonly AppDbContext _context;

        public CaixaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Caixa> Caixas => _context.Caixas;

        public Caixa GetCaixaById(int caixaId)
        {
            return _context.Caixas.FirstOrDefault(p => p.CaixaId == caixaId);
        }
    }
}
