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

        public async Task<IEnumerable<Trabajadores>> GetTrabajadores()
        {
            var trabajadores = await _trabajadoresRepository.GetAll();
            return trabajadores;
        }

        public async Task<Trabajadores> GetTrabajador(int id)
        {
            var trabajador = await _trabajadoresRepository.GetById(id);
            return trabajador;
        }

        public async Task InsertTrabajador(Trabajadores trabajador)
        {
            await _trabajadoresRepository.Add(trabajador);
        }

        public async Task<bool> UpDateTrabajador(Trabajadores trabajador)
        {
            await _trabajadoresRepository.Update(trabajador);
            return true;
        }

        public async Task<bool> DeleteTrabajador(int id)
        {
            await _trabajadoresRepository.Delete(id);
            return true;
        }
    }
}
