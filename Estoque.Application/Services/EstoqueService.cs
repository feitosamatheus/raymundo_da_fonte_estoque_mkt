using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Estoque.Application.Interfaces;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Application.ViewModels.Infra;
using Estoque.Application.ViewModels.Pedido;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;

namespace Estoque.Application.Services
{
    public class EstoqueService : IEstoqueService
    {

        private IEstoqueRepository _estoqueRepository;
        private IInfraRepository _infraRepository;
        private readonly IMapper _maper;


        public EstoqueService(IEstoqueRepository estoqueRepository, IInfraRepository infraRepository, IMapper maper)
        {
            _estoqueRepository= estoqueRepository;
            _infraRepository = infraRepository;
            _maper = maper;
        }

        public async Task<EstoqueViewModel> GetItemPorId(int id)
        {
            var resultado = await _estoqueRepository.GetItemPorId(id);
            return _maper.Map<EstoqueViewModel>(resultado);
        }

        public IQueryable<EstoqueViewModel> GetItensFiltro(string filter)
        {
            var resultado = _estoqueRepository.GetItensFiltro(filter);

            return resultado.ProjectTo<EstoqueViewModel>(_maper.ConfigurationProvider).AsQueryable();
        }

        public IEnumerable<FilialViewModel> GetFiliais()
        {
            var resultado = _infraRepository.GetFiliais();
            return _maper.Map<IEnumerable<FilialViewModel>>(resultado);

        }
    }
}