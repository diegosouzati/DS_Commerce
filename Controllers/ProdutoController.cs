using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DS_Commerce.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Estoque()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
    }
}