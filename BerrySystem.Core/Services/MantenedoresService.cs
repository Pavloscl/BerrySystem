using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Services
{
    public class MantenedoresService : IMantenedoresService
    {
        private readonly IRepository<Sectores> _sectoresRepository;
        private readonly IRepository<PresentacionProductos> _prestProdRepository;

        public MantenedoresService(IRepository<Sectores> sectoresRepository, IRepository<PresentacionProductos> prestProdRepository)
        {
            _sectoresRepository = sectoresRepository;
            _prestProdRepository = prestProdRepository;
        }

        public Task<IEnumerable<PresentacionProductos>> GetPrestProds()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Sectores>> GetSectores()
        {
            throw new System.NotImplementedException();
        }

        public Task<PresentacionProductos> GetPrestProd(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Sectores> GetSector(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertPrestProd(PresentacionProductos sectores)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertSector(Sectores sectores)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpDatePrestProd(PresentacionProductos Sectores)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpDateSector(Sectores Sectores)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeletePrestProd(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteSectores(int id)
        {
            throw new System.NotImplementedException();
        }

 
    }
}
