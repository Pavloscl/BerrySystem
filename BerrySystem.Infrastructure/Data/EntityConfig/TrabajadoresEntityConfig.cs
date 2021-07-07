using BerrySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BerrySystem.Infrastructure.Data.EntityConfig
{
    public class TrabajadoresEntityConfig : IEntityTypeConfiguration<Trabajadores>
    {
        public void Configure(EntityTypeBuilder<Trabajadores> builder)
        {
            builder.Property(e => e.ApMaterno)
                    .IsRequired()
                    .HasColumnName("Ap_Materno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(e => e.ApPaterno)
                .IsRequired()
                .HasColumnName("Ap_Paterno")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.DigitoVerificador)
                .HasColumnName("Digito_Verificador")
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComputedColumnSql("([dbo].[CalculaDigitoRut]([Rut]))");

            builder.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FechaBaja)
                .HasColumnName("Fecha_Baja")
                .HasColumnType("date");

            builder.Property(e => e.FechaIngreso)
                .HasColumnName("Fecha_Ingreso")
                .HasColumnType("date");

            builder.Property(e => e.IdSector).HasColumnName("Id_Sector");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.Sectores)
                .WithMany(p => p.Trabajadores)
                .HasForeignKey(d => d.IdSector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trabajadores_Sector");
        }
    }
}
