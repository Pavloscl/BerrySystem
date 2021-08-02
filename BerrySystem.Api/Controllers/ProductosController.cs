using AutoMapper;
using BerrySystem.Core.DTOs;
using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductosService _productoService;
        private readonly IMapper _mapper;

        public ProductosController(IProductosService productosService, IMapper mapper)
        {
            _productoService = productosService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {
            var productos = await _productoService.GetProducts();
            var productosDto = _mapper.Map<IEnumerable<ProductosDto>>(productos);
            return Ok(productosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducto(int id)
        {
            var producto = await _productoService.GetProduct(id);
            var productoDto = _mapper.Map<ProductosDto>(producto);
            return Ok(productoDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProducto(ProductosDto productoDto)
        {
            var producto = _mapper.Map<Productos>(productoDto);
            await _productoService.InsertProduct(producto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpDateProducto(int id, ProductosDto productoDto)
        {
            var producto = _mapper.Map<Productos>(productoDto);
            producto.Id = id;

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
