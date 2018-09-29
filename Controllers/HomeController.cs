using Aula01.Data;
using Aula01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Controllers
{
    public class HomeController : Controller
    {
        private PerguntaContext _context;

        public HomeController(PerguntaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //ViewBag.Nome = "Flavio";
            //ViewData["NomDoAluno"] = $"Outro nome {DateTime.Now}";                    
            
            return View(_context.Pergunta.ToList());
        }
        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult Ajuda()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                _context.Pergunta.Add(pergunta);
                await _context.SaveChangesAsync();            
            }
            return View();
        }

    }
}
