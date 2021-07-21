using BerrySystem.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Interfaces
{
    public interface ICosechasService
    {
        Task<IEnumerable<Cosechas>> GetCosechas();

        Task<Cosechas> GetCosecha(int id);

        Task InsertCosecha(Cosechas cosecha);

        Task<bool> UpDateCosecha(Cosechas cosecha);

        Task<bool> DeleteCosecha(int id);
    }
}
