using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Domain.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public int OrderPrice { get; set;}

        [ForeignKey("User")]
        public string UserId = string.Empty;

        public List <Pizza>? Pizzas = new List<Pizza>();


    }
}
