using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class Tipo
    {
        public int IdTipo { get; set; }
        public string DescTipo { get; set; }
        public string InseridoPor { get; set; }
        public DateTime InseridoEm { get; set; }
        public bool Status { get; set; }

        public ICollection<Item> Itens { get; set; }
    }
}
