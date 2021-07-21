using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Services
{
    public class CosechasService : ICosechasService
    {
        private readonly IRepository<Cosechas> _cosechasRepository;

        public CosechasService(IRepository<Cosechas> cosechasRepository)
        {
            _cosechasRepository = cosechasRepository;
        }

        public Task<IEnumerable<Cosechas>> GetCosechas()
        {
            throw new System.NotImplementedException();
        }
        public Task<Cosechas> GetCosecha(int id)
        {
            throw new System.NotImplementedException();
        }
        public Task InsertCosecha(Cosechas cosecha)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpDateCosecha(Cosechas cosecha)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteCosecha(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}
