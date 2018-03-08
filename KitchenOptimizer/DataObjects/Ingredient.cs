using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenOptimizer.DataObjects
{
    [Table("Ingredient")]
    public class Ingredient
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string IngredientName { get; set; }
        public decimal IngredientCost { get; set; }
        public int IngredientCategory { get; set; }
    }
}
