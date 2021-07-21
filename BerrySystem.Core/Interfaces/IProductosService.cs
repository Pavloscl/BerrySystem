using BerrySystem.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Interfaces
{
    public interface IProductosService
    {
        Task<IEnumerable<Productos>> GetProducts();

        Task<Productos> GetProduct(int id);

        Task InsertProduct(Productos producto);

        Task<bool> UpDateProduct(Productos producto);

        Task<bool> DeleteProduct (int id);
    }
}
