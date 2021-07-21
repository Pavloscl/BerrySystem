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

        public Task<Productos> GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertProduct(Productos producto)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpDateProduct(Productos producto)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}
