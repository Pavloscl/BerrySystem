using BerrySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerrySystem.Infrastructure.Data.EntityConfig
{
    public class DetalleCosechaEntityConfig : IEntityTypeConfiguration<DetalleCosecha>
    {
        public void Configure(EntityTypeBuilder<DetalleCosecha> builder)
        {
            builder.ToTable("Detalle_Cosecha");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.IdCosecha).HasColumnName("Id_Cosecha");

            builder.Property(e => e.IdPresentacion).HasColumnName("Id_Presentacion");

            builder.Property(e => e.IdProducto).HasColumnName("Id_Producto");

            builder.Property(e => e.KilosBruto).HasColumnName("Kilos_Bruto");

            builder.HasOne(d => d.Cosechas)
                .WithMany(p => p.DetalleCosecha)
                .HasForeignKey(d => d.IdCosecha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Detalle_Cosecha_Cosechas");

            builder.HasOne(d => d.PresentacionProductos)
                .WithMany(p => p.DetalleCosecha)
                .HasForeignKey(d => d.IdPresentacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Detalle_Cosecha_PresentacionProduct");

            builder.HasOne(d => d.Productos)
                .WithMany(p => p.DetalleCosecha)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Detalle_Cosecha_Producto");
        }
    }
}
