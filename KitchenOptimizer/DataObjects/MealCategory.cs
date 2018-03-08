using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenOptimizer.DataObjects
{
    [Table("MealCategory")]
    public class MealCategory
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string CategoryName { get; set; }
    }
}
