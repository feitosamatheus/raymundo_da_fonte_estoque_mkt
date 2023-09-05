using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Estoque.MVC.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services){
            if(services == null) throw new ArgumentNullException(nameof(services));
            
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), 
            typeof(ViewModelToDomainMappingProfile));
        }
    }
}