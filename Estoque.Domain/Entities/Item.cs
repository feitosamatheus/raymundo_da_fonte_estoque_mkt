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
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdItem { get; set; }
        public int CodItem { get; set; }
        public int IdFilial { get; set; }
        public int IdTipo { get; set; }
        public string DescItem { get; set; }
        public long Quantidade { get; set; }
        public string UrlImagem { get; set; }
        public string Observacao { get; set; }
        public string InseridoPor { get; set; }
        public DateTime InseridoEm { get; set; }
        public bool Status { get; set; }
        
        public Filial FilialId { get; set; }
        public Tipo TipoId { get; set; }

    }
}
