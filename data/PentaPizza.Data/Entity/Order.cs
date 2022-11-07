using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaPizza.Data.Entity
{
    [Table("Orders", Schema = "Order")]
    public class Order
    {
        public Pizza PizzaName { get; set; }
        public int OrderId { get; set; }
    }
}