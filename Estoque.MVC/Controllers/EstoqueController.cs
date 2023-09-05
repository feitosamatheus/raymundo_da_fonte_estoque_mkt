using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Estoque.MVC.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly IEstoqueService _estoqueService;


        public EstoqueController(IEstoqueService estoqueService)
        {
            _estoqueService = estoqueService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var resultado = await _estoqueService.GetItems();
            return View(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> BuscarItemPorId(int id)
        {
            var resultado = await _estoqueService.GetItemPorId(id);
            return View("Error!");
        }
    }
}