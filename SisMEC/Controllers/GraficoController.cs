using Microsoft.AspNetCore.Mvc;
using SisMEC.Controllers.Services;
using System;

namespace SisMEC.Controllers
{
    public class GraficoController : Controller
    {

        private readonly GraficoServicosService _graficoServicos;

        public GraficoController(GraficoServicosService graficoServicos)
        {
            _graficoServicos = graficoServicos ?? throw new ArgumentNullException(nameof(graficoServicos));
        }

        public JsonResult GrafServicos()
        {
            var servicosTotais = _graficoServicos.GetServicoGraf();
            return Json(servicosTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ServicosMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ServicosSemanal()
        {
            return View();
        }
    }
}
