using System;
using System.Collections.Generic;
using System.Text;

namespace BerrySystem.Core.DTOs
{
    public class CosechasTrabajadorDto
    {
        public CosechasTrabajadorDto()
        {
            DetalleCosecha = new HashSet<DetalleCosechaDto>();
        }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FechaCosecha { get; set; }
        public int TotalKilos { get; set; }
        public virtual ICollection<DetalleCosechaDto> DetalleCosecha { get; set; }
    }
}