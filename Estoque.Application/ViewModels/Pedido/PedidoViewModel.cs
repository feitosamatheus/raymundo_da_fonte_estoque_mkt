using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Application.ViewModels.Pedido
{
    public class PedidoViewModel
    {
        [DisplayName("Código")]
        public string CodPedido { get; set; }
        public int QtdPedida { get; set; }
        public int QtdAtendida { get; }

        public string NotaFiscal { get; set; }
        public int IdCliente { get; set; }
        public int IdItem { get; set; }
        public int IdSituacao { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataFaturamento { get; set; }
        public DateTime DataFinalizacao { get; set; }

        public SituacaoPedido Situacao { get; set; }
        public Item Item { get; set; }
        public Cliente Cliente { get; set; }
    }
}
