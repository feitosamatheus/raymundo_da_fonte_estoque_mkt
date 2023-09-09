using AutoMapper;
using Estoque.Application.Interfaces;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Application.ViewModels.Pedido;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Application.Services
{
    public class PedidoService : IPedidoService
    {
        private IPedidoRepository _pedidoRepository;
        private readonly IMapper _maper;


        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _maper = mapper;

        }

        public async Task<PedidoViewModel> GetPedido(int id)
        {
            var resultado = await _pedidoRepository.GetPedido(id);

            return _maper.Map<PedidoViewModel>(resultado);

        }

        public PedidoViewModel GetPedidoMock()
        {
            var resultado =  _pedidoRepository.GetPedidoMock();


            var conversao = _maper.Map<PedidoViewModel>(resultado);

            return conversao;
        }
    }
}
