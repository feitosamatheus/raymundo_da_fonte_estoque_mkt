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
        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "CodItem")
        {
            var filiais = _estoqueService.GetFiliais();
            ViewBag.Filiais = new MultiSelectList(filiais, "CodFilial", "DescFilial");

            var itens = _estoqueService.GetItensFiltro(filter);

            var model = await PagingList.CreateAsync(itens, 1, pageindex, sort, "CodItem");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }
    }
}