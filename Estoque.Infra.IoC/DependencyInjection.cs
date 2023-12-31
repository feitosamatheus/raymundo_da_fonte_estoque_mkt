﻿using Estoque.Application.Interfaces;
using Estoque.Application.Services;
using Estoque.Domain.Interfaces;
using Estoque.Infra.Data.Context;
using Estoque.Infra.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            //services.AddIdentity<IdentityUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //        .AddDefaultTokenProviders();

            services.AddScoped<IEstoqueRepository, EstoqueRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IInfraRepository, InfraRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<ILoginService, LoginService>();
        
            return services;
        }
    }
}
