using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DS_Commerce.Controllers
{
    public class FinanceiroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContasAReceber()
        {
            return View();
        }

        public IActionResult ContasAPagar()
        {
            return View();
        }
    }
}