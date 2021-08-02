using System;
using System.Collections.Generic;
using System.Text;

namespace BerrySystem.Core.DTOs
{
    public class PresentacionProductosDto
    {
        public int Id { get; set; }
        public string TipoPrest { get; set; }
        public double? DescCosecha { get; set; }
        public double? DescVenta { get; set; }
    }
}
