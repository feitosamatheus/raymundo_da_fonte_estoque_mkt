using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Application.Interfaces;
using Estoque.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ReflectionIT.Mvc.Paging;

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
        public async Task<IActionResult> Index(string filter, int filial,int tipo, int pageindex = 1, string sortExpression = "CodItem")
        {
            var filiais = await _estoqueService.GetFiliais();
            ViewBag.Filiais = filiais;

            var tipos = await _estoqueService.GetTipos();
            ViewBag.Tipos = tipos;

            var itens = _estoqueService.GetItensFiltro(filter, filial);

            var model = await PagingList.CreateAsync(itens, 3, pageindex, sortExpression, "CodItem");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }
    }
}