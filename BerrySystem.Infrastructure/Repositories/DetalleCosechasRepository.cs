using BerrySystem.Core.Entities;
using BerrySystem.Core.Interfaces;
using BerrySystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BerrySystem.Infrastructure.Repositories
{
    public class DetalleCosechasRepository : BaseRepository<DetalleCosecha>, IDetalleCosechaRepository
    {
        public DetalleCosechasRepository(BerrySystemContext context) : base(context)
        {
        }
    }
}
