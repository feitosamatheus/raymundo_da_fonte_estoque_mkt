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
    public class ItemConfig: IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(c => c.IdItem);
            builder.Property(p => p.DescItem).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            builder.HasOne(p => p.Filial).WithMany(b => b.Itens).HasForeignKey(p => p.IdFilial);
            builder.HasOne(p => p.Tipo).WithMany(b => b.Itens).HasForeignKey(p => p.IdTipo);

        }
    }
}
