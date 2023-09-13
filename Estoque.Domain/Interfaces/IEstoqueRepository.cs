using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Interfaces
{
    public interface IEstoqueRepository
    {
        Task<IEnumerable<Item>> GetItems();
        Task<Item> GetItemPorId(int id);
        IQueryable<Item> GetItensFiltro(string filter, int filial);
    }
}
