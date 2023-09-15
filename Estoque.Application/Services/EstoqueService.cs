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

        public IQueryable<EstoqueViewModel> GetItensFiltro(string filter, int tipo, int filial)
        {
            var resultado = _estoqueRepository.GetItensFiltro(filter, tipo, filial);

            return resultado.ProjectTo<EstoqueViewModel>(_maper.ConfigurationProvider).AsQueryable();
        }

        public async Task<IEnumerable<FilialViewModel>> GetFiliais()
        {
            var resultado = await _infraRepository.GetFiliais();
            return _maper.Map<IEnumerable<FilialViewModel>>(resultado);
        }

        public async Task<IEnumerable<TipoViewModel>> GetTipos()
        {
            var resultado = await _infraRepository.GetTipos();
            return _maper.Map<IEnumerable<TipoViewModel>>(resultado);
        }
    }
}