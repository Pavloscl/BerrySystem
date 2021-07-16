using BerrySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerrySystem.Infrastructure.Data.EntityConfig
{
    public class ProductoEntityConfig : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            //entity.Property(e => e.Id).ValueGeneratedNever(); // Para evitar generar Id autonumerico

           // builder.ToTable("Productos"); //En el caso de que nuestra tablam tenga un nombre diferente
            
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.PrecioCompra)
                .HasColumnName("Precio_Compra");
            //.HasColumnType("money");

            builder.Property(e => e.PrecioCosecha)
                .HasColumnName("Precio_Cosecha");
                //.HasColumnType("money");

            builder.Property(e => e.PrecioVenta)
                .HasColumnName("Precio_Venta");
                //.HasColumnType("money");
        }
    }
}
