using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Services
{
    public class TrabajadoresService : ITrabajadoresService
    {
        private readonly IRepository<Trabajadores> _trabajadoresRepository;

        public TrabajadoresService(IRepository<Trabajadores> trabajadoresRepository)
        {
            _trabajadoresRepository = trabajadoresRepository;
        }

        public  Task<IEnumerable<Trabajadores>> GetTrabajadores()
        {
            throw new System.NotImplementedException();
        }

        public Task<Trabajadores> GetTrabajador(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertTrabajador(Trabajadores producto)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpDateTrabajador(Trabajadores producto)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteTrabajador(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
