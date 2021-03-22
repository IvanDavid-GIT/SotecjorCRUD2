using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SotecjorCRUD2.Controllers
{
    public class BienvenidoController : Controller
    {
        public IActionResult Indice()
        {
            return View();
        }
    }
}
