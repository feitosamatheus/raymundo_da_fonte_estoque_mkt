using Estoque.Application.Interfaces;
using Estoque.Application.ViewModels.Pedido;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            var listaSituacaoPedido = _pedidoService.GetSituacaoPedido();
            ViewBag.ListaSituacaoPedido = new SelectList(listaSituacaoPedido, "IdSituacao", "DescSituacao");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BuscarPedidos(FiltroPedidoViewModel filtro)
        {
            var quantidadePorPagina = 2;
            var paginaIndex = filtro.Pageindex == 0 ? 1 : filtro.Pageindex;
            var ordernacao = string.IsNullOrEmpty(filtro.SortExpression) ? "CodPedido" : filtro.SortExpression; 

            var relatorioPedido = _pedidoService.GetPedidos(filtro.CodPedido);

            var model = await PagingList.CreateAsync(relatorioPedido, quantidadePorPagina, paginaIndex, ordernacao, "CodPedido");
            model.RouteValue = new RouteValueDictionary { { "filter", filtro.CodPedido } };
            model.Action = "BuscarPedidos";

            return PartialView("Partial/_RelatorioPedido", model);
        }
    }
}
