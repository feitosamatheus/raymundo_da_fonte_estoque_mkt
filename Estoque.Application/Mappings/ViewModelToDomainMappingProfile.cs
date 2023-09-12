using AutoMapper;
using Estoque.Application.ViewModels;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Application.ViewModels.Infra;
using Estoque.Application.ViewModels.Pedido;
using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //CreateMap<PedidoViewModel, Pedido>().ForMember(p => p.CodPedido, pv => pv.MapFrom(p => p.CodPedido));
            CreateMap<PedidoViewModel, Pedido>();
            CreateMap<EstoqueViewModel, Item>();
            CreateMap<FilialViewModel, Filial>();
        }
    }
}
