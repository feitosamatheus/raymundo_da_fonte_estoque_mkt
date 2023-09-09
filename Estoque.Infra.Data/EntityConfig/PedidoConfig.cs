using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.EntityConfig
{
    public  class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(c => c.IdPedido);
            builder.Property(p => p.IdPedido).IsRequired();
            builder.Property(p => p.CodPedido).IsRequired();
            builder.Property(p => p.IdCliente).IsRequired();
            builder.Property(p => p.IdItem).IsRequired();
            builder.Property(p => p.IdSituacao).IsRequired();
            builder.Property(p => p.QtdAtendida).IsRequired();
            builder.Property(p => p.QtdPedida).IsRequired();
            builder.HasOne(p => p.Situacao).WithMany(b => b.Pedidos).HasForeignKey(p => p.IdSituacao);
            builder.HasOne(p => p.Item).WithMany(b => b.Pedidos).HasForeignKey(p => p.IdItem);
            builder.HasOne(p => p.Cliente).WithMany(b => b.Pedidos).HasForeignKey(p => p.IdCliente);

        }
    }
}
