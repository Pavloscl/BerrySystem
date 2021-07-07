using BerrySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BerrySystem.Infrastructure.Data.EntityConfig
{
    public class PrestProductEntityConfig : IEntityTypeConfiguration<PresentacionProductos>
    {
        public void Configure(EntityTypeBuilder<PresentacionProductos> builder)
        {
            builder.ToTable("Presentacion_Productos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.DescCosecha).HasColumnName("Desc_Cosecha");

            builder.Property(e => e.DescVenta).HasColumnName("Desc_Venta");

            builder.Property(e => e.TipoPrest)
                .HasColumnName("Tipo_Prest")
                .HasMaxLength(50);
        }
    }
}
