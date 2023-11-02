using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Domain.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public List <Ingredients> Ingredients = new List<Ingredients> ();
        
    }
}
