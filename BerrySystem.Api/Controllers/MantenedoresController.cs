using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerrySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MantenedoresController : ControllerBase
    {
        private readonly IMantenedoresService _mantenedoresService;
        public MantenedoresController(IMantenedoresService mantenedoresService)
        {

            _mantenedoresService = mantenedoresService;
        }
        //Mantenedor Sectores
        //  Api/Mantenedores/Sectores
        [HttpGet]
        [Route("Sectores")]
        public async Task<IActionResult> GetSectores()
        {

            var sectores = await _mantenedoresService.GetSectores();
            return Ok(sectores);

        }

        [HttpGet("Sectores/{id}")]
       
        public async Task<IActionResult> GetSector(int id)
        {
            var sector = await _mantenedoresService.GetSector(id);
            return Ok(sector);
        }

        [HttpPost]
        [Route("Sectores")]
        public async Task<IActionResult> CreateSector(Sectores sector)
        {
            await _mantenedoresService.InsertSector(sector);
            return Ok();
        }

        [HttpPut]
        [Route("Sectores")]
        public async Task<IActionResult> UpDateSector(int id, Sectores sector)
        {

            await _mantenedoresService.UpDateSector(sector);
            return Ok(true);
        }

        [HttpDelete("Sectores/{id}")]
        //[Route("Sectores")]
        public async Task<IActionResult> DeleteSector(int id)
        {
            await _mantenedoresService.DeleteSectores(id);
            return Ok(true);
        }

        //Mantenedor Presentación Productos
        [HttpGet("PrestProd")]
        public async Task<IActionResult> GetPrestProds()
        {

            var prestProds = await _mantenedoresService.GetPrestProds();
            return Ok(prestProds);

        }

        [HttpGet("PrestProd/{id}")]
        
        public async Task<IActionResult> GetPrestProd(int id)
        {
            var prestProd = await _mantenedoresService.GetPrestProd(id);
            return Ok(prestProd);
        }

        [HttpPost("PrestProd")]
        public async Task<IActionResult> CreatePrestProd(PresentacionProductos prestProd)
        {
            await _mantenedoresService.InsertPrestProd(prestProd);
            return Ok();
        }

        [HttpPut("PrestProd")]
        public async Task<IActionResult> UpDatePrestProd(int id, PresentacionProductos prestProd)
        {

            await _mantenedoresService.UpDatePrestProd(prestProd);
            return Ok(true);
        }

        [HttpDelete("PrestProd/{id}")]
        public async Task<IActionResult> DeletePrestProd(int id)
        {
            await _mantenedoresService.DeletePrestProd(id);
            return Ok(true);
        }
    }
}
