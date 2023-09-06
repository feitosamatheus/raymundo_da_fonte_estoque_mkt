using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Domain.Entities;

namespace Estoque.Application.ViewModels.Estoque
{
    public class EstoqueViewModel
    {

        [DisplayName("Código")]
        public int CodItem { get; set; }

        [DisplayName("Filial")]
        public int IdFilial { get; set; }

        [DisplayName("Tipo")]
        public int IdTipo { get; set; }

        [DisplayName("Descrição")]
        public string DescItem { get; set; }

        [DisplayName("Quantidade")]
        public long Quantidade { get; set; }

        [DisplayName("Imagem")]
        public string UrlImagem { get; set; }
        
        [DisplayName("Observação")]
        public string Observacao { get; set; }

    }
}