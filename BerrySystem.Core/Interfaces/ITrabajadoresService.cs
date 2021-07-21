using BerrySystem.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Interfaces
{
    public  interface ITrabajadoresService 
    {
        Task<IEnumerable<Trabajadores>> GetTrabajadores();

        Task<Trabajadores> GetTrabajador(int id);

        Task InsertTrabajador(Trabajadores trabajador);

        Task<bool> UpDateTrabajador(Trabajadores trabajador);

        Task<bool> DeleteTrabajador(int id);
    }
}

