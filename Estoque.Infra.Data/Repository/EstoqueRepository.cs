using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.Repository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly ApplicationDbContext _context;

        public EstoqueRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public Item GetItemPorId(int id)
        {
            return _context.Items.First(i => i.IdItem == id);

        }

        public IEnumerable<Item> GetItems()
        {
            return _context.Items;
        }
    }
}
