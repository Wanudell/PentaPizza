using PentaPizza.Data.Abstractions;
using PentaPizza.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaPizza.Data.Concretes
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly PentaPizzaDbContext context;

        public PizzaRepository(PentaPizzaDbContext context)
        {
            this.context = context;
        }

        public List<Pizza> GetPizzas()
        {
            return context.Pizzas.Select(s => new Pizza
            {
                Id = s.Id,
                Name = s.Name,
                Price = s.Price,
                Ingredients = s.Ingredients
            }).ToList();
        }
    }
}