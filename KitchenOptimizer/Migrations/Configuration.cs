namespace KitchenOptimizer.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<KitchenOptimizer.EntityDataModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(KitchenOptimizer.EntityDataModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.IngredientCategories.AddOrUpdate(
                    p => p.CategoryName,
                    new DataObjects.IngredientCategory { CategoryName = "Dairy"},
                    new DataObjects.IngredientCategory { CategoryName = "Condiment" },
                    new DataObjects.IngredientCategory { CategoryName = "Meat" },
                    new DataObjects.IngredientCategory { CategoryName = "Baking" },
                    new DataObjects.IngredientCategory { CategoryName = "Produce" },
                    new DataObjects.IngredientCategory { CategoryName = "Bread" },
                    new DataObjects.IngredientCategory { CategoryName = "Pasta" },
                    new DataObjects.IngredientCategory { CategoryName = "Cookies" },
                    new DataObjects.IngredientCategory { CategoryName = "Crackers" },
                    new DataObjects.IngredientCategory { CategoryName = "Chips" },
                    new DataObjects.IngredientCategory { CategoryName = "Non-Food" },
                    new DataObjects.IngredientCategory { CategoryName = "Seasonings" },
                    new DataObjects.IngredientCategory { CategoryName = "Candy" }
                );

            context.MealCategories.AddOrUpdate(
                    s => s.CategoryName,
                    new DataObjects.MealCategory { CategoryName = "Mexican" },
                    new DataObjects.MealCategory { CategoryName = "Italian" },
                    new DataObjects.MealCategory { CategoryName = "Indian" },
                    new DataObjects.MealCategory { CategoryName = "Easy" },
                    new DataObjects.MealCategory { CategoryName = "Cajun" },
                    new DataObjects.MealCategory { CategoryName = "Southern" },
                    new DataObjects.MealCategory { CategoryName = "Sauce" },
                    new DataObjects.MealCategory { CategoryName = "Dessert" },
                    new DataObjects.MealCategory { CategoryName = "Chinese" }
                );
        }
    }
}
