using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Core.Services
{
    public class ProductosService : IProductosService
    {
        private readonly IRepository<Productos> _productRepository;
        public ProductosService(IRepository<Productos> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Productos>> GetProducts()
        {
            var productos = await _productRepository.GetAll();
            return productos;
        }

        public async Task<Productos> GetProduct(int id)
        {
            var productos = await _productRepository.GetById(id);
            return productos;
        }

        public async  Task InsertProduct(Productos producto)
        {
              await _productRepository.Add(producto);
        }

        public async  Task<bool> UpDateProduct(Productos producto)
        {
          await  _productRepository.Update(producto);
           return true;
        }
         
        public async Task<bool> DeleteProduct(int id)
        {
            await _productRepository.Delete(id);
            return true;
        }

    }
}
