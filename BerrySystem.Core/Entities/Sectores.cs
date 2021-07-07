using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BerrySystem.Core.Entities
{
    public partial class Sectores
    {
        public Sectores()
        {
            Trabajadores = new HashSet<Trabajadores>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Comuna { get; set; }

        public virtual ICollection<Trabajadores> Trabajadores { get; set; }
    }
}
