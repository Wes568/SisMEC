using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SisMEC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public string ServicosGraficos()
        //{
        //    var itens = _logger.ObterNumeroLivrosPorEditora();
        //    var json = itens.ToGoogleDataTable()
        //        .NewColumn(new Column(ColumnType.String, "Editora"), x => x.NomeEditora)
        //        .NewColumn(new Column(ColumnType.Number, "Quantidade"), x => x.CountLivros)
        //        .Build()
        //        .GetJson();
        //    return json;
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
