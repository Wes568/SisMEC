using SisMEC.Context;
using SisMEC.Models;
using SisMEC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private readonly AppDbContext _context;

        public CarroRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Carro> Carros => _context.Carros;

        public Carro GetCarroById(int carroId)
        {
            return _context.Carros.FirstOrDefault(p => p.CarroId == carroId);
        }
    }
}
