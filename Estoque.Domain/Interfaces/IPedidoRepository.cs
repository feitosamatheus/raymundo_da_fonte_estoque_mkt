using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Task<Pedido> GetPedido(int id);

        Pedido GetPedidoMock();
    }
}
