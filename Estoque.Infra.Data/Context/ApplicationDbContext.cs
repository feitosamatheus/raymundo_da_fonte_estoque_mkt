using Estoque.Domain.Entities;
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
        public DbSet<Item> Itens { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<SituacaoPedido> SituacaoPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cliente>().HasKey(c => c.IdCliente);
            builder.Entity<SituacaoPedido>().HasKey(c => c.IdSituacao);

            builder.ApplyConfiguration(new FilialConfig());          
            builder.ApplyConfiguration(new ItemConfig());
            builder.ApplyConfiguration(new TipoConfig());
            builder.ApplyConfiguration(new PedidoConfig());

        }
    }
}