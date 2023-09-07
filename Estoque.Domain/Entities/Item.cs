using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class Item
    {
        public int IdItem { get; set; }
        public int CodItem { get; set; }
        public string DescItem { get; set; }
        public long Quantidade { get; set; }
        public decimal PrecoItem { get; set; }
        public string Observacao { get; set; }
        public string UrlImagem { get; set; }
        public string InseridoPor { get; set; }
        public DateTime InseridoEm { get; set; }
        public bool Status { get; set; }
        
        public int IdFilial { get; set; }
        public Filial Filial { get; set; }

        public int IdTipo { get; set; }
        public Tipo Tipo { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}
