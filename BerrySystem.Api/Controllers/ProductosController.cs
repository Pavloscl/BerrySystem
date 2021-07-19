using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerrySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
      
        private readonly IRepository<Productos> _productRepository;
        public ProductosController(
           
            IRepository<Productos> productRepository)
        {
          
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
           
            var product = await _productRepository.GetAll();
           
            
            return Ok (product);
                
        }


    }
}
