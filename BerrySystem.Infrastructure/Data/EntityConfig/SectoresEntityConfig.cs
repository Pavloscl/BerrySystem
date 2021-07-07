using BerrySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerrySystem.Infrastructure.Data.EntityConfig
{
    public class SectoresEntityConfig : IEntityTypeConfiguration<Sectores>
    {
        public void Configure(EntityTypeBuilder<Sectores> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Comuna)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Longaví')");

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
