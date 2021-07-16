using BerrySystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BerrySystem.Core.Interfaces
{
  public  interface IProductRespository
    {
        Task<IEnumerable<Productos>> GetProduct();
    }
}
