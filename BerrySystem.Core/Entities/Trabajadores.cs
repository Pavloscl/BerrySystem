using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BerrySystem.Core.Entities
{
    public partial class Trabajadores
    {
        public Trabajadores()
        {
            Cosechas = new HashSet<Cosechas>();
        }

        public int Id { get; set; }
        public int Rut { get; set; }
        public string DigitoVerificador { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Direccion { get; set; }
        public int IdSector { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual Sectores Sectores { get; set; }
        public virtual ICollection<Cosechas> Cosechas { get; set; }
    }
}
