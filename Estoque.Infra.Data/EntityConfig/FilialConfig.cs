using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.EntityConfig
{
    public class FilialConfig: IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.HasKey(c => c.IdFilial);
            builder.Property(p => p.IdFilial).IsRequired();
            builder.Property(p => p.CodFilial).IsRequired();
            builder.Property(p => p.IsMatriz).IsRequired();
        }
    }
}
