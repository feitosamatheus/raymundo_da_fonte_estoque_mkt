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
        public Filial IdFilial { get; set; }

        [DisplayName("Tipo")]
        public Tipo IdTipo { get; set; }

        [DisplayName("Descrição")]
        public string DescItem { get; set; }

        [DisplayName("Quntidade")]
        public long Quantidade { get; set; }

        [DisplayName("Imagem")]
        public string UrlImagem { get; set; }
        
        [DisplayName("Observação")]
        public string Observacao { get; set; }

    }
}