using BerrySystem.Core.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Interfaces
{

    public interface IMantenedoresService
    {
        //Mantenedor Sectores
        Task<IEnumerable<Sectores>> GetSectores();

        Task<Sectores> GetSector(int id);

        Task InsertSector(Sectores sectores);

        Task<bool> UpDateSector(Sectores Sectores);

        Task<bool> DeleteSectores(int id);


        //Mantenedor PresentacionProductos
        Task<IEnumerable<PresentacionProductos>> GetPrestProds();

        Task<PresentacionProductos> GetPrestProd(int id);

        Task InsertPrestProd(PresentacionProductos sectores);

        Task<bool> UpDatePrestProd(PresentacionProductos Sectores);

        Task<bool> DeletePrestProd(int id);

    }

    
}
