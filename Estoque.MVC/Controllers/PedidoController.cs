using Estoque.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ReflectionIT.Mvc.Paging;

namespace Estoque.MVC.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "CodPedido")
        {
            var resultado = _pedidoService.GetPedidos(filter);

            var model = await PagingList.CreateAsync(resultado, 2, pageindex, sort, "CodPedido");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }

    }
}
