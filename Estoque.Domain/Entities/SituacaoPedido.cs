using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class SituacaoPedido
    {
        public int IdSituacao { get; set; }
        public string DescSituacao { get; set; }
        public bool Status { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
