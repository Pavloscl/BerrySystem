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

        private readonly IProductosService _productoService;
        public ProductosController(IProductosService productosService)
        {

            _productoService = productosService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {
            var productos = await _productoService.GetProducts();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducto(int id)
        {
            var producto = await _productoService.GetProduct(id);
            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProducto(Productos producto)
        {
            await _productoService.InsertProduct(producto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpDateProducto(int id, Productos producto)
        {
            await _productoService.UpDateProduct(producto);
            return Ok(true);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
             await _productoService.DeleteProduct(id);
             return Ok(true);
        }

    }
}
