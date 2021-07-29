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

        //Mantenedor Sectores
        public async Task<IEnumerable<Sectores>> GetSectores()
        {
            var sectores = await _sectoresRepository.GetAll();
            return sectores;
        }

        public async Task<Sectores> GetSector(int id)
        {
            var sector = await _sectoresRepository.GetById(id);
            return sector;
        }
        public async Task InsertSector(Sectores sector)
        {
            await _sectoresRepository.Add(sector);
        }

        public async Task<bool> UpDateSector(Sectores sector)
        {
            await _sectoresRepository.Update(sector);
            return true;
        }

        public async Task<bool> DeleteSectores(int id)
        {
            await _sectoresRepository.Delete(id);
            return true;
        }

        //Mantenedor Presentacion Productos
        public async Task<IEnumerable<PresentacionProductos>> GetPrestProds()
        {
            var prestProd = await _prestProdRepository.GetAll();
            return prestProd;
        }

        public async Task<PresentacionProductos> GetPrestProd(int id)
        {
            var prestProd = await _prestProdRepository.GetById(id);
            return prestProd;
        }

        public async Task InsertPrestProd(PresentacionProductos prestProd)
        {
            await _prestProdRepository.Add(prestProd);
        }

        public async Task<bool> UpDatePrestProd(PresentacionProductos prestProd)
        {
            await _prestProdRepository.Update(prestProd);
            return true;
        }
        public async Task<bool> DeletePrestProd(int id)
        {
            await _prestProdRepository.Delete(id);
            return true;
        }
    }
}
