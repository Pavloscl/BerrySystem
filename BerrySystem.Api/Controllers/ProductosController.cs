using BerrySystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerrySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private readonly IProductosService _productoService;
        public ProductosController(IProductosService productosService)
        {

            _productoService = productosService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {

            var product = await _productoService.GetProducts();
           
            
            return Ok (product);
                
        }


    }
}
