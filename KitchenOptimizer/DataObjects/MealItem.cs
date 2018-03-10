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
        public string Ingredient1 { get; set; }
        public string Ingredient2 { get; set; }
        public string Ingredient3 { get; set; }
        public string Ingredient4 { get; set; }
        public string Ingredient5 { get; set; }
        public string Ingredient6 { get; set; }
        public string Ingredient7 { get; set; }
        public string Ingredient8 { get; set; }
        public string Ingredient9 { get; set; }
        public string Ingredient10 { get; set; }
        public string Ingredient11 { get; set; }
        public string Ingredient12 { get; set; }
        public string Ingredient13 { get; set; }
    }
}
