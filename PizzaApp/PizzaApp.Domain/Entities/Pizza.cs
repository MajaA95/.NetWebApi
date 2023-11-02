using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Domain.Entities
{
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
                                    
        public int Price { get; set; }
        public string Name { get; set; }

        [ForeignKey("User")]
        public string UserId = string.Empty;  

        public List <Ingredients> Ingredients = new List<Ingredients> ();

        public Order Order { get; set; }
        
    }
}
