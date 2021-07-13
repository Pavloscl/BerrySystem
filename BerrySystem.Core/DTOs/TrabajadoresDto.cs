using System;

namespace BerrySystem.Core.DTOs
{
    public  class TrabajadoresDto
    {
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

    }
}
