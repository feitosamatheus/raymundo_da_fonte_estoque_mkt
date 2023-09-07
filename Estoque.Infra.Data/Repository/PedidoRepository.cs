using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationDbContext _context;
        
        public PedidoRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<Pedido> GetPedido(int id)
        {
            return await _context.Pedidos.FirstAsync(i => i.IdPedido == id);
        }
    }
}
