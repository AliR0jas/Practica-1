using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Resultado(Practica p)
        {
            return View(p);
        }
    }
}
