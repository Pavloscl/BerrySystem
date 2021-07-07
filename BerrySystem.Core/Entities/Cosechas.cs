using System;
using System.Collections.Generic;


// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BerrySystem.Core.Entities
{
    public partial class Cosechas
    {
        public Cosechas()
        {
            DetalleCosecha = new HashSet<DetalleCosecha>();
        }

        public int Id { get; set; }
        public int IdTrabajador { get; set; }
        public DateTime FechaCosecha { get; set; }

        public virtual Trabajadores Trabajadores { get; set; }
        public virtual ICollection<DetalleCosecha> DetalleCosecha { get; set; }
    }
}
