using Microsoft.AspNetCore.Mvc;
using SisMEC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Controllers
{
    public class CarroController : Controller
    {
        private readonly ICarroRepository _carroRepository;

        public CarroController(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public IActionResult List()
        {
            var carros = _carroRepository.Carros;
            return View(carros);
        }
    }
}
