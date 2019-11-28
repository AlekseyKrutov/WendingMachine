namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYardProdQuantityTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductQuantities",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Id)
                .Index(t => t.Id);
            
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
            DropForeignKey("dbo.ProductQuantities", "Id", "dbo.Products");
            DropIndex("dbo.ProductQuantityYards", new[] { "Yard_Id" });
            DropIndex("dbo.ProductQuantityYards", new[] { "ProductQuantity_Id" });
            DropIndex("dbo.ProductQuantities", new[] { "Id" });
            DropTable("dbo.ProductQuantityYards");
            DropTable("dbo.ProductQuantities");
        }
    }
}
