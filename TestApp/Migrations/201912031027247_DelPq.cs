namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelPq : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductQuantities", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies");
            DropForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities");
            DropForeignKey("dbo.ProductQuantityYards", "Yard_Id", "dbo.Yards");
            DropIndex("dbo.ProductQuantities", new[] { "Product_Id" });
            DropIndex("dbo.ProductQuantities", new[] { "Supply_Id" });
            DropIndex("dbo.ProductQuantityYards", new[] { "ProductQuantity_Id" });
            DropIndex("dbo.ProductQuantityYards", new[] { "Yard_Id" });
            DropTable("dbo.ProductQuantities");
            DropTable("dbo.ProductQuantityYards");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductQuantityYards",
                c => new
                    {
                        ProductQuantity_Id = c.Int(nullable: false),
                        Yard_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductQuantity_Id, t.Yard_Id });
            
            CreateTable(
                "dbo.ProductQuantities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RealCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Product_Id = c.Int(),
                        Supply_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ProductQuantityYards", "Yard_Id");
            CreateIndex("dbo.ProductQuantityYards", "ProductQuantity_Id");
            CreateIndex("dbo.ProductQuantities", "Supply_Id");
            CreateIndex("dbo.ProductQuantities", "Product_Id");
            AddForeignKey("dbo.ProductQuantityYards", "Yard_Id", "dbo.Yards", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies", "Id");
            AddForeignKey("dbo.ProductQuantities", "Product_Id", "dbo.Products", "Id");
        }
    }
}
