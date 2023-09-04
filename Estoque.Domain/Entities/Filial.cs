using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class Filial
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdFilial { get; set; }
        public int CodFilial { get; set; }
        public string DescFilial { get; set; }
        public bool IsMatriz { get; set; }
        public string InseridoPor { get; set; }
        public DateTime InseridoEm { get; set; }
        public bool Status { get; set; }
    }
}
