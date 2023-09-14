using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Application.ViewModels.Infra;

namespace Estoque.Application.Interfaces
{
    public interface IEstoqueService
    {
        Task<EstoqueViewModel> GetItemPorId(int id);
        IQueryable<EstoqueViewModel> GetItensFiltro(string filter, int filial);
        Task<IEnumerable<FilialViewModel>> GetFiliais();
        Task<IEnumerable<TipoViewModel>> GetTipos();
    }
}