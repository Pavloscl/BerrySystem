using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BerrySystem.Core.Entities
{
    public partial class Productos
    {
        public Productos()
        {
            DetalleCosecha = new HashSet<DetalleCosecha>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal? PrecioCosecha { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioCompra { get; set; }

        public virtual ICollection<DetalleCosecha> DetalleCosecha { get; set; }
    }
}
