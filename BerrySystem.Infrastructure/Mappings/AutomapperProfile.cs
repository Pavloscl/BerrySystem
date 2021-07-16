using AutoMapper;
using BerrySystem.Core.DTOs;
using BerrySystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BerrySystem.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
         CreateMap<Productos, ProductosDto>().ReverseMap();
         CreateMap<Trabajadores, TrabajadoresDto>().ReverseMap();
         CreateMap<Sectores, SectoresDto>().ReverseMap();
         CreateMap<DetalleCosecha, DetalleCosechaDto>().ReverseMap();
        }
    }
}
