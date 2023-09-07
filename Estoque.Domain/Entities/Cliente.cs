using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
