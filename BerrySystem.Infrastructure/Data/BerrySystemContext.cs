using BerrySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BerrySystem.Infrastructure.Data
{
    public partial class BerrySystemContext : DbContext
    {
        public BerrySystemContext()
        {
        }

        public BerrySystemContext(DbContextOptions<BerrySystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cosechas> Cosechas { get; set; }
        public virtual DbSet<DetalleCosecha> DetalleCosecha { get; set; }
        public virtual DbSet<PresentacionProductos> PresentacionProductos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Sectores> Sectores { get; set; }
        public virtual DbSet<Trabajadores> Trabajadores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
