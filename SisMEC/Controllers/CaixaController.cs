using Microsoft.AspNetCore.Mvc;
using SisMEC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Controllers
{
    public class CaixaController : Controller
    {
        private readonly ICaixaRepository _caixaRepository;

        public CaixaController(ICaixaRepository caixaRepository)
        {
            _caixaRepository = caixaRepository;
        }

        public IActionResult List()
        {
            var caixas = _caixaRepository.Caixas;
            return View(caixas);
        }
    }
}
