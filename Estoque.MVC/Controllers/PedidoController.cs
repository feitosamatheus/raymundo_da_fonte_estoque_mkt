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

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BuscarPedidos(string filter, int pageindex = 1, string sortExpression = "CodPedido")
        {
            const int quantidadePorPagina = 4;
            var resultado = _pedidoService.GetPedidos(filter);

            var model = await PagingList.CreateAsync(resultado, quantidadePorPagina, pageindex, sortExpression, "CodPedido");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };
            model.Action = "BuscarPedidos";



            return PartialView("Partial/_RelatorioPedido", model);
        }
    }
}
