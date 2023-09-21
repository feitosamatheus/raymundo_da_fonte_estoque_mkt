using Estoque.Application.ViewModels.Infra;
using Estoque.Application.ViewModels.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Application.Interfaces
{
    public interface IPedidoService
    {
        Task<PedidoViewModel> GetPedido(int id);

        IQueryable<PedidoViewModel> GetPedidos(string filter);

        IEnumerable<SituacaoPedidoViewModel> GetSituacaoPedido();
    }
}
