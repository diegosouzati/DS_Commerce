using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DS_Commerce.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VendasTotal()
        {
            return View("Index");
        }

        public IActionResult VendasPorCliente()
        {
            return View("Index");
        }

        public IActionResult VendasPorVendedor()
        {
            return View("Index");
        }

        public IActionResult ItensMaisVendidos()
        {
            return View("Index");
        }
    }
}