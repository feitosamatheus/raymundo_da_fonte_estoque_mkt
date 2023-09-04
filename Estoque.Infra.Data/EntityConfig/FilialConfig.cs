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
            builder.Property(p => p.IdFilial).IsRequired();
            builder.Property(p => p.CodFilial).HasMaxLength(100).IsRequired();
            builder.Property(p => p.DescFilial).HasMaxLength(100).IsRequired();
            builder.Property(p => p.IsFilial).IsRequired();
            builder.Property(p => p.Status).IsRequired();

            //builder.HasData(
            //    new Filial
            //    {
            //        CodFilial = 101,
            //        DescFilial = "MATRIZ",
            //        IsFilial = true,
            //        Status = true,
            //        InseridoPor = "54321",
            //        InseridoEm = DateTime.Now
            //    }
            //    //,
            //    //new Filial
            //    //{
            //    //    CodFilial = 102,
            //    //    DescFilial = "Salvador",
            //    //    IsFilial = false,
            //    //    Status = true,
            //    //    InseridoPor = "54321",
            //    //    InseridoEm = DateTime.Now
            //    //}
            //);
        }
    }
}
