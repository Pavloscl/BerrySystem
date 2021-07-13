using System;
using System.Collections.Generic;
using System.Text;

namespace BerrySystem.Core.DTOs
{
    public class DetalleCosechaDto
    {
        public int Id { get; set; }
        public int IdCosecha { get; set; }
        public int IdProducto { get; set; }
        public int KilosBruto { get; set; }
        public int IdPresentacion { get; set; }
        public int Cantidad { get; set; }
        public int Descuentos { get; set; }
    }
}
