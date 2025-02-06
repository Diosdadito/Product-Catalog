using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductsCatalog.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Products");
        }

        //POST

        //PUT

        //DELETE
    }
}
