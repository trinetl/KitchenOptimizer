namespace KitchenOptimizer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataObjects;

    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=EntityDataModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MealItem> MealItems { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<IngredientCategory> IngredientCategories { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
    }
}
