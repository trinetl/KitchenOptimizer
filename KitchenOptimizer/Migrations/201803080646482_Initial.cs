namespace KitchenOptimizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IngredientName = c.String(maxLength: 2147483647),
                        IngredientCost = c.String(maxLength: 2147483647),
                        IngredientCategory = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MealItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MealItemName = c.String(maxLength: 2147483647),
                        Ingredient1 = c.Int(nullable: false),
                        Ingredient2 = c.Int(nullable: false),
                        Ingredient3 = c.Int(nullable: false),
                        Ingredient4 = c.Int(nullable: false),
                        Ingredient5 = c.Int(nullable: false),
                        Ingredient6 = c.Int(nullable: false),
                        Ingredient7 = c.Int(nullable: false),
                        Ingredient8 = c.Int(nullable: false),
                        Ingredient9 = c.Int(nullable: false),
                        Ingredient10 = c.Int(nullable: false),
                        Ingredient11 = c.Int(nullable: false),
                        Ingredient12 = c.Int(nullable: false),
                        Ingredient13 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MealName = c.String(maxLength: 2147483647),
                        MealCategory = c.String(maxLength: 2147483647),
                        MealItem1 = c.Int(nullable: false),
                        MealItem2 = c.Int(nullable: false),
                        MealItem3 = c.Int(nullable: false),
                        MealItem4 = c.Int(nullable: false),
                        MealItem5 = c.Int(nullable: false),
                        MealItem6 = c.Int(nullable: false),
                        MealItem7 = c.Int(nullable: false),
                        MealItem8 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Meal");
            DropTable("dbo.MealItem");
            DropTable("dbo.Ingredient");
        }
    }
}
