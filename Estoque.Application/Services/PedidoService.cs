﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Estoque.Application.Interfaces;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Application.ViewModels.Infra;
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
        private IInfraRepository _infraRepository;
        private readonly IMapper _maper;

        public PedidoService(IPedidoRepository pedidoRepository, IInfraRepository infraRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _infraRepository = infraRepository;
            _maper = mapper;

        }

        public async Task<PedidoViewModel> GetPedido(int id)
        {
            var resultado = await _pedidoRepository.GetPedido(id);

            return _maper.Map<PedidoViewModel>(resultado);

        }

        public IQueryable<PedidoViewModel> GetPedidos(string filter)
        {
            var resultado = _pedidoRepository.GetPedidos(filter);

            return resultado.ProjectTo<PedidoViewModel>(_maper.ConfigurationProvider).AsQueryable(); ;
        }

        public  IEnumerable<SituacaoPedidoViewModel> GetSituacaoPedido() {

            var listaSituacaoPedido =  _infraRepository.GetSituacaoPedido();
            return _maper.Map<IEnumerable<SituacaoPedidoViewModel>>(listaSituacaoPedido);
        }

     }
}
