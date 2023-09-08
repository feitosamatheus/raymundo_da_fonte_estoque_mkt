using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Application.ViewModels.Pedido;
using Estoque.Domain.Entities;

namespace Estoque.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Pedido, PedidoViewModel>().ForMember(p => p.CodPedido, pv => pv.MapFrom(p => p.CodPedido));
            CreateMap<Item, EstoqueViewModel>();
        }
    }
}