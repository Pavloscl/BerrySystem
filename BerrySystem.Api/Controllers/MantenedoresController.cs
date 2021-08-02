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
    public class MantenedoresController : ControllerBase
    {
        private readonly IMantenedoresService _mantenedoresService;
        private readonly IMapper _mapper;

        public MantenedoresController(IMantenedoresService mantenedoresService, IMapper mapper)
        {

            _mantenedoresService = mantenedoresService;
            _mapper = mapper;
        }
        //Mantenedor Sectores
        //  Api/Mantenedores/Sectores
        [HttpGet]
        [Route("Sectores")]
        public async Task<IActionResult> GetSectores()
        {
            var sectores = await _mantenedoresService.GetSectores();
            var sectoresDto = _mapper.Map<IEnumerable<SectoresDto>>(sectores);
            return Ok(sectoresDto);

        }

        [HttpGet("Sectores/{id}")]
       
        public async Task<IActionResult> GetSector(int id)
        {
            var sector = await _mantenedoresService.GetSector(id);
            var sectorDto = _mapper.Map<SectoresDto>(sector);
            return Ok(sectorDto);
        }

        [HttpPost]
        [Route("Sectores")]
        public async Task<IActionResult> CreateSector(SectoresDto sectorDto)
        {
            var sector= _mapper.Map<Sectores>(sectorDto);
            await _mantenedoresService.InsertSector(sector);
            return Ok();
        }

        [HttpPut]
        [Route("Sectores")]
        public async Task<IActionResult> UpDateSector(int id, SectoresDto sectorDto)
        {
            var sector= _mapper.Map<Sectores>(sectorDto);
            sector.Id = id;
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
            var prestProdsDto= _mapper.Map<IEnumerable<PresentacionProductosDto>>(prestProds);
            return Ok(prestProdsDto);
        }

        [HttpGet("PrestProd/{id}")]
        
        public async Task<IActionResult> GetPrestProd(int id)
        {
            var prestProd = await _mantenedoresService.GetPrestProd(id);
            var prestProdDto = _mapper.Map<PresentacionProductosDto>(prestProd);
            return Ok(prestProd);
        }

        [HttpPost("PrestProd")]
        public async Task<IActionResult> CreatePrestProd(PresentacionProductosDto prestProdDto)
        {
            var prestProd= _mapper.Map<PresentacionProductos>(prestProdDto);
            await _mantenedoresService.InsertPrestProd(prestProd);
            return Ok();
        }

        [HttpPut("PrestProd")]
        public async Task<IActionResult> UpDatePrestProd(int id, PresentacionProductosDto prestProdDto)
        {
            var prestProd = _mapper.Map<PresentacionProductos>(prestProdDto);
            prestProd.Id = id;
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
