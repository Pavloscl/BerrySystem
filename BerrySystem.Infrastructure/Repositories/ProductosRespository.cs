using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using BerrySystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Infrastructure.Repositories
{
    public class ProductosRepository  : BaseRepository<Productos>, IProductRepository
    {
        private readonly BerrySystemContext _context;

        public ProductosRepository(BerrySystemContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Productos>> GetProduct()
        {
            
            var productos = await _context.Productos.ToListAsync();
            

            return productos;
        }

        
    }
}
