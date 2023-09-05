using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Estoque.Application.ViewModels.Estoque;
using Estoque.Domain.Entities;

namespace Estoque.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Item, EstoqueViewModel>();
        }
    }
}