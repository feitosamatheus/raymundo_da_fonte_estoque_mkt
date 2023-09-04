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
            builder.Property(p => p.IdTipo).IsRequired();
            builder.Property(p => p.IdFilial).IsRequired();
            builder.Property(p => p.DescItem).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Status).IsRequired();
        }
    }
}
