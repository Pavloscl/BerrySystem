using BerrySystem.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Interfaces
{
    public  interface IProductRepository : IRepository<Productos>
    {
        Task<IEnumerable<Productos>> GetProduct();
    }
}
