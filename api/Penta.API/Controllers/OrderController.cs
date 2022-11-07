using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PentaPizza.Data;
using PentaPizza.Data.Context;

namespace Penta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly PentaPizzaDbContext dbContext;

        public OrderController(PentaPizzaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(dbContext.Orders.ToList());
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            //var pizza = dbContext.Orders.FirstOrDefault(x => x.OrderId == id);
            return Ok(/*new Pizza { Id = pizza.OrderId, Name = $"{pizza.PizzaName}" }*/);

            //Düşünülecek.
        }
    }
}