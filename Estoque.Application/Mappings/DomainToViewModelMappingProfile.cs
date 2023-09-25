using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Application.ViewModels.Infra;
using Estoque.Application.ViewModels.Login;
using Estoque.Application.ViewModels.Pedido;
using Estoque.Domain.Entities;

namespace Estoque.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            //CreateMap<Pedido, PedidoViewModel>().ForMember(p => p.CodPedido, pv => pv.MapFrom(p => p.CodPedido));
            CreateMap<Pedido, PedidoViewModel>();
            CreateMap<Item, EstoqueViewModel>();
            CreateMap<Filial, FilialViewModel>();
            CreateMap<Tipo, TipoViewModel>();
            CreateMap<SituacaoPedido, SituacaoPedidoViewModel>();
            CreateMap<Usuario, LoginViewModel>();
        }
    }
}