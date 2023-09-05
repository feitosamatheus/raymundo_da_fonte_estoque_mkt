using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Application.ViewModels.Estoque;

namespace Estoque.Application.Interfaces
{
    public interface IEstoqueService
    {
        Task<IEnumerable<EstoqueViewModel>> GetItems();
        Task<EstoqueViewModel> GetItemPorId(int id);
    }
}