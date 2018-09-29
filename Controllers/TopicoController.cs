using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
    public class TopicoController : Controller
    {
        public IActionResult Index(string categoria, string topico)
        {
            return View();
        }
    }
}