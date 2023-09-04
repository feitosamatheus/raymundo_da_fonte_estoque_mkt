﻿using Estoque.Domain.Entities;
using Estoque.Infra.Data.EntityConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace Estoque.Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        
            builder.Entity<Filial>().HasKey(c => c.IdFilial);
            builder.ApplyConfiguration(new FilialConfig());

            builder.Entity<Item>().HasKey(c => c.IdItem);
            builder.ApplyConfiguration(new ItemConfig());

            builder.Entity<Tipo>().HasKey(c => c.IdTipo);
            builder.ApplyConfiguration(new TipoConfig());
        }
    }
}