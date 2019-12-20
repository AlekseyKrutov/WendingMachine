namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPqTable : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Supplies", t => t.Supply_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Supply_Id);
            
            CreateTable(
                "dbo.ProductQuantityYards",
                c => new
                    {
                        ProductQuantity_Id = c.Int(nullable: false),
                        Yard_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductQuantity_Id, t.Yard_Id })
                .ForeignKey("dbo.ProductQuantities", t => t.ProductQuantity_Id, cascadeDelete: true)
                .ForeignKey("dbo.Yards", t => t.Yard_Id, cascadeDelete: true)
                .Index(t => t.ProductQuantity_Id)
                .Index(t => t.Yard_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductQuantityYards", "Yard_Id", "dbo.Yards");
            DropForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities");
            DropForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies");
            DropForeignKey("dbo.ProductQuantities", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductQuantityYards", new[] { "Yard_Id" });
            DropIndex("dbo.ProductQuantityYards", new[] { "ProductQuantity_Id" });
            DropIndex("dbo.ProductQuantities", new[] { "Supply_Id" });
            DropIndex("dbo.ProductQuantities", new[] { "Product_Id" });
            DropTable("dbo.ProductQuantityYards");
            DropTable("dbo.ProductQuantities");
        }
    }
}
