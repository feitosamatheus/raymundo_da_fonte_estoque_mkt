﻿using Estoque.Application.Interfaces;
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
            var resultado = await _pedidoService.GetPedido(1);
            return View(resultado);
        }
    }
}