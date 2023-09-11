using Estoque.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.MVC.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public async Task<IActionResult> Index()
        {
            var resultado = await _pedidoService.GetPedido(3);
            return View(resultado);
        }

        public IActionResult IndexMock()
        {
            return View();
        }

        public IActionResult IndexMock(string filter, int pageindex = 1, string sort = "Nome")
        {
            var resultado = _pedidoService.GetPedidoMock();
            return View(resultado);
        }

    }
}
