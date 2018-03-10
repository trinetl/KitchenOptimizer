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
        public string MealCategory { get; set; }
        public string MealItem1 { get; set; }
        public string MealItem2 { get; set; }
        public string MealItem3 { get; set; }
        public string MealItem4 { get; set; }
        public string MealItem5 { get; set; }
        public string MealItem6 { get; set; }
        public string MealItem7 { get; set; }
        public string MealItem8 { get; set; }
    }
}
