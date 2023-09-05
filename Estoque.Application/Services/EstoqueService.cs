using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Estoque.Application.Interfaces;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;

namespace Estoque.Application.Services
{
    public class EstoqueService : IEstoqueService
    {

        private IEstoqueRepository _estoqueRepository;
        private readonly IMapper _maper;


        public EstoqueService(IEstoqueRepository estoqueRepository, IMapper maper)
        {
            _estoqueRepository= estoqueRepository;
            _maper = maper;
        }

        public async Task<EstoqueViewModel> GetItemPorId(int id)
        {
            var resultado = await _estoqueRepository.GetItemPorId(id);
            return _maper.Map<EstoqueViewModel>(resultado);
        }

        public async Task<IEnumerable<EstoqueViewModel>> GetItems()
        {
            var resultado = await _estoqueRepository.GetItems();
            return _maper.Map<IEnumerable<EstoqueViewModel>>(resultado);
        }
    }
}