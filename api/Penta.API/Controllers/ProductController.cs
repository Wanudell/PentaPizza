using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PentaPizza.Data.Context;

namespace Penta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly PentaPizzaDbContext dbContext;

        public ProductController(PentaPizzaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetPizzas()
        {
            return Ok(dbContext.Pizzas.ToList());
        }
    }
}