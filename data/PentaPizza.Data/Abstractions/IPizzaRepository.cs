using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaPizza.Data.Abstractions
{
    public interface IPizzaRepository
    {
        List<Pizza> GetPizzas();
    }
}