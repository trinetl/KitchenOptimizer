using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenOptimizer.DataObjects
{
    [Table("Meal")]
    public class Meal
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string MealName { get; set; }
        public int MealCategory { get; set; }
        public int MealItem1 { get; set; }
        public int MealItem2 { get; set; }
        public int MealItem3 { get; set; }
        public int MealItem4 { get; set; }
        public int MealItem5 { get; set; }
        public int MealItem6 { get; set; }
        public int MealItem7 { get; set; }
        public int MealItem8 { get; set; }
    }
}
