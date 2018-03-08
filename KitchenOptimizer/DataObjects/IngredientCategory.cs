using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenOptimizer.DataObjects
{
    [Table("IngredientCategory")]
    public class IngredientCategory
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string CategoryName { get; set; }
    }
}
