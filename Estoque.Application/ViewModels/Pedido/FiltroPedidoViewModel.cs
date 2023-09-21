using System.ComponentModel;

namespace Estoque.Application.ViewModels.Pedido
{
    public class FiltroPedidoViewModel
    {
        [DisplayName("Situação")]
        public int IdSituacao { get; set; }

        [DisplayName("Nota Fiscal")]
        public string NotaFiscal { get; set; }

        [DisplayName("Pedido")]
        public string CodPedido { get; set; }

        public int Pageindex  { get; set; }
        
        public string SortExpression { get; set; }
    }
}
