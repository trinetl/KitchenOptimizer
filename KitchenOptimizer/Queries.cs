using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenOptimizer
{
    class Queries
    {
        public static readonly string INGREDIENT_FORM =
            (@"select i.Id, i.IngredientName, i.IngredientCost, i.IngredientCategory 
               from Ingredient i;");
        internal static readonly string UPDATE_INGREDIENT = 
            @"update Ingredient
              set IngredientName = '{1}',
              IngredientCost = '{2}',
              IngredientCategory = '{3}'
              where Id = {0};
              ";
        internal static readonly string INSERT_INGREDIENT =
            @"
                insert into Ingredient (IngredientName, IngredientCost, IngredientCategory)
                VALUES
                ('{0}', '{1}', '{2}');
            ";
        internal static readonly string DELETE_INGREDIENT =
            @"
                delete from Ingredient
                where id = {0};
            ";
    }
}
