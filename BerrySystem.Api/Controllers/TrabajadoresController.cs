using AutoMapper;
using BerrySystem.Core.DTOs;
using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BerrySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly ITrabajadoresService _trabajadoresService;
        private readonly IMapper _mapper;

        public TrabajadoresController(ITrabajadoresService trabajadoresService, IMapper mapper)
        {
            _trabajadoresService = trabajadoresService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrabajadores()
        {
            var trabajadores = await _trabajadoresService.GetTrabajadores();
            var trabajadoresDto= _mapper.Map<IEnumerable<TrabajadoresDto>>(trabajadores);
            return Ok(trabajadoresDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrabajador(int id)
        {
            var trabajador = await _trabajadoresService.GetTrabajador(id);
            var trabajadorDto = _mapper.Map<TrabajadoresDto>(trabajador);
            return Ok(trabajadorDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrabajador(Trabajadores trabajador)
        {
            await _trabajadoresService.InsertTrabajador(trabajador);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpDateTrabajador(int id, TrabajadoresDto trabajadoresDto)
        {
            var trabajadores= _mapper.Map<Trabajadores>(trabajadoresDto);
            trabajadores.Id = id;
            await _trabajadoresService.UpDateTrabajador(trabajadores);
            return Ok(true);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrabajador(int id)
        {
            await _trabajadoresService.DeleteTrabajador(id);
            return Ok(true);
        }

    }
}
