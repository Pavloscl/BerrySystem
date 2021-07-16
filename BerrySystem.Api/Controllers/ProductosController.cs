using BerrySystem.Core.Interfaces;
using BerrySystem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerrySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
       // private readonly BerrySystemContext _context;
        private readonly IProductRespository _productRespository;

        public ProductosController(
           
            IProductRespository productRespository)
        {
           // _context = context;
            _productRespository = productRespository;
        }

        [HttpGet]
        public async Task <IActionResult> GetProduct()
        {
            var product = await _productRespository.GetProduct();

            return Ok (product);
                
        }


    }
}
