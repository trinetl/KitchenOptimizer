using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenOptimizer.DataObjects
{
    [Table("MealItem")]
    public class MealItem
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string MealItemName { get; set; }
        public int Ingredient1 { get; set; }
        public int Ingredient2 { get; set; }
        public int Ingredient3 { get; set; }
        public int Ingredient4 { get; set; }
        public int Ingredient5 { get; set; }
        public int Ingredient6 { get; set; }
        public int Ingredient7 { get; set; }
        public int Ingredient8 { get; set; }
        public int Ingredient9 { get; set; }
        public int Ingredient10 { get; set; }
        public int Ingredient11 { get; set; }
        public int Ingredient12 { get; set; }
        public int Ingredient13 { get; set; }
    }
}
