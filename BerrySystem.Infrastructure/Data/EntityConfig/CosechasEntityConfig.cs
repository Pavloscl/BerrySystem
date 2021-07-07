using BerrySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerrySystem.Infrastructure.Data.EntityConfig
{
    public class CosechasEntityConfig : IEntityTypeConfiguration<Cosechas>
    {
        public void Configure(EntityTypeBuilder<Cosechas> builder)
        {
           builder.ToTable("Cosechas");

           builder.HasKey(e => e.Id);

           builder.Property(e => e.FechaCosecha)
                    .HasColumnName("Fecha_Cosecha")
                    .HasColumnType("date");

           builder.Property(e => e.IdTrabajador).HasColumnName("Id_Trabajador");

           builder.HasOne(d => d.Trabajadores)
                .WithMany(p => p.Cosechas)
                .HasForeignKey(d => d.IdTrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cosechas_Trabajador");

        }
    }
}
