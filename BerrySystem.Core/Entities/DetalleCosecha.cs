// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BerrySystem.Core.Entities
{
    public partial class DetalleCosecha
    {
        public int Id { get; set; }
        public int IdCosecha { get; set; }
        public int IdProducto { get; set; }
        public int KilosBruto { get; set; }
        public int IdPresentacion { get; set; }
        public int Cantidad { get; set; }
        public int Descuentos { get; set; }

        public virtual Cosechas Cosechas { get; set; }
        public virtual PresentacionProductos PresentacionProductos { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
