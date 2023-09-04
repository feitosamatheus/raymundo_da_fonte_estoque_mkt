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

            //builder.HasData(
            //    new Item
            //    {
            //        DescItem = " EXP. CARAMBOLA GIRATORIO - MINI ",
            //        Status = true,
            //        CodItem = 9729,
            //        IdTipo = 1,
            //        IdFilial = 1,
            //        UrlImagem = "https://lh3.googleusercontent.com/JrPy6Vb5JzQtspAgnTHvy3cuf3LU8ufVkah3iEa3osnn6HzUDuo8sSfQ32uEXnc=w600",
            //        InseridoPor = "54321",
            //        InseridoEm = DateTime.Now
            //    }
            //    //,
            //    //new Item
            //    //{
            //    //    DescItem = "EXP. CARAMBOLA GIRATORIO - PEQ ",
            //    //    Status = true,
            //    //    CodItem = 47357,
            //    //    IdTipo = 1,
            //    //    IdFilial = 1,
            //    //    UrlImagem = "https://lh3.googleusercontent.com/s9K1NpsAXwwMEni0wEuvGMgDgbzqGFF-ikHvKtnD7TPpYbskutxL6QcehfFH6Q=w600",
            //    //    InseridoPor = "54321",
            //    //    InseridoEm = DateTime.Now
            //    //}
            //);
        }
    }
}
